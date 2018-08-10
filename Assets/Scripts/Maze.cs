using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Maze {

	public class Coord {
		public int x;
		public int y;
		public Coord(int x, int y) {
			this.x = x;
			this.y = y;
		}
	}

	public enum Square {
		PATH,
		WALL,
		ENTRANCE,
		EXIT
	}

	protected int length = 64;
	protected int width = 64;
	protected int max_height = 3;
	protected int min_height = 0;
	protected Coord offset = new Coord(0,0);
	protected int scale = 1;

	protected Square[,] maze;

	public Maze() {
		maze = new Square[length, width];
	}

	public abstract void Algorithm();

	protected void PopulateMaze() {
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				if (maze [i, j] == Square.WALL) {
					for (int x = 0; x < scale; x++) {
						for (int y = 0; y < scale; y++) {
							for (int k = 0; k < UnityEngine.Random.Range(min_height*scale,max_height*scale); k++) {
								MakeCube(i*scale+(x), j*scale+(y), k);
							}
						}
					}
				}
			}
		}
	}

	protected void MakeBorders() {
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				if (i == 0 || i == length - 1 || j == 0 || j == width - 1) {
					maze[i,j] = Square.WALL;
				}
			}
		}
	}

	protected void MakeFloor() {
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				for (int x = 0; x < scale; x++) {
					for (int y = 0; y < scale; y++) {
						MakeCube(i*scale+(x), j*scale+(y), -1);
					}
				}
			}
		}
	}

	void MakeCube(int length, int width, int height) {
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.AddComponent<Rigidbody>();
		cube.GetComponent<Rigidbody>().useGravity = false;
		cube.transform.position = new Vector3(length + offset.x, height, width + offset.y);
	}

	public bool allPathsAreReachable() {
		bool[,] visited = new bool[length,width];
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				for (int k = 0; k < max_height; k++) {
					visited[i,j] = false;
				}
			}
		}

		HashSet<Coord> allPaths = getAllCoordsOf(new Square[]{Square.PATH, Square.ENTRANCE, Square.EXIT});
		Coord entrance = findEntrance();
		HashSet<Coord> visitedPaths = new HashSet<Coord>();
		return allPathsAreReachableRecursive(entrance, visitedPaths, allPaths, visited);
	}

	private bool allPathsAreReachableRecursive(Coord c, HashSet<Coord> visitedPaths, HashSet<Coord> allPaths, bool[,] visited) {
		if (c == null)
			return false;
		int x = c.x;
		int y = c.y;
		try {
			Square s = maze[x,y];
		}
		catch (IndexOutOfRangeException) {
			return false;
		}
		if (visited[x,y] == true) {
			return false;
		}
		else if (maze[x,y] == Square.WALL) {
			return false;
		}
		else if (maze[x,y] == Square.PATH || maze[x,y] == Square.ENTRANCE || maze[x,y] == Square.EXIT) {
			visited[x,y] = true;
			visitedPaths.Add(new Coord(x,y));
		}

		//forward
		allPathsAreReachableRecursive(new Coord(x+1, y), visitedPaths, allPaths, visited);

		//right
		allPathsAreReachableRecursive(new Coord(x, y+1), visitedPaths, allPaths, visited);

		//backward
		allPathsAreReachableRecursive(new Coord(x-1, y), visitedPaths, allPaths, visited);

		//left
		allPathsAreReachableRecursive(new Coord(x, y-1), visitedPaths, allPaths, visited);

		return (visitedPaths.Equals(allPaths));
	}

	private bool isSolvableRecursive(Coord sq, bool[,] visited) {
		if (sq == null) {
			return false;
		}
		try {
			Square s = maze[sq.x,sq.y];
		}
		catch (IndexOutOfRangeException) {
			return false;
		}
		if (maze[sq.x,sq.y] == Square.WALL || visited[sq.x,sq.y] == true) {
			return false;
		}
		else if (maze[sq.x,sq.y] == Square.EXIT) {
			return true;
		}

		visited[sq.x,sq.y] = true;

		//forward
		return isSolvableRecursive(new Coord(sq.x+1,sq.y), visited) ||

			//right
			isSolvableRecursive(new Coord(sq.x,sq.y+1), visited) ||

			//backward
			isSolvableRecursive(new Coord(sq.x-1,sq.y), visited) ||

			//left
			isSolvableRecursive(new Coord(sq.x,sq.y-1), visited);
	}

	private void addEntrance() {
		Coord c = getBorderSquare();
		maze[c.x,c.y] = Square.ENTRANCE;
		//		while (has(c, Square.EXIT)) {
		//			maze[c.x,c.y] = Square.ENTRANCE;
		//			c = getBorderSquare();
		//		}
	}

	private void addExit() {
		Coord c = getBorderSquare();
		maze[c.x,c.y] = Square.EXIT;
		//		while (has(c, Square.ENTRANCE)) {
		//			maze[c.x,c.y] = Square.EXIT;
		//			c = getBorderSquare();
		//		}
	}

	private bool has(Coord c, Square type) {
		if (maze[c.x,c.y] == type) {
			return true;
		}
		return false;
	}

	private Coord findEntrance() {
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				if (maze[i,j] == Square.ENTRANCE) {
					return new Coord(i, j);
				}
			}
		}
		return null;
	}

	public HashSet<Coord> getAllCoordsOf(Square[] types) {
		HashSet<Coord> result = new HashSet<Coord>();
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				foreach (Square type in types) {
					if (maze[i,j] == type)
						result.Add(new Coord(i,j));
				}
			}
		}
		return result;
	}

	private Coord getBorderSquare() {
		//		int x = rnd.Next(length);
		//		int y = rnd.Next(width);
		int x = UnityEngine.Random.Range(0,length-1);
		int y = UnityEngine.Random.Range(0,width-1);

		//		int side = rnd.Next(4);
		int side = UnityEngine.Random.Range(0,3);
		switch (side) {
		case 0:
			x = 0;
			break;
		case 1:
			x = length - 1;
			break;
		case 2:
			y = 0;
			break;
		case 3:
			y = width - 1;
			break;
		}
		return new Coord(x,y);
	}

	public bool isSolvable() {
		Coord entrance = findEntrance();
		bool[,] visited = new bool[length,width];
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				visited[i,j] = false;
			}
		}
		return isSolvableRecursive(entrance, visited);
	}

	protected void initFull() {
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				maze [i,j] = Square.WALL;
			}
		}
	}

	public bool hasCoord(List<Coord> walls, Coord coord) {
		foreach (Coord c in walls) {
			if (c.x == coord.x && c.y == coord.y) {
				return true;
			}
		}
		return false;
	}

	public bool hasCoord(HashSet<Coord> set, Coord coord) {
		foreach (Coord c in set) {
			if (c.x == coord.x && c.y == coord.y) {
				return true;
			}
		}
		return false;
	}

	void DrawMaze() {
		Console.Write("\n");
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				if (maze [i, j] == Square.WALL) {
					Console.Write("#");
				}
				else {
					Console.Write (".");
				}
			}
			Console.Write("\n");
		}
	}

}
