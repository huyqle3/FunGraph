using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimMaze : Maze {

	public void Go() {
		MakeFloor();
		Algorithm();
		PopulateMaze();
	}

	override public void Algorithm() {
		initFull();
		List<Coord> walls = new List<Coord>();
		List<Coord> visited = new List<Coord>();
		Coord start = new Coord (4,4);
		maze[start.x, start.y] = Square.PATH;
		visited.Add(start);
		walls = addNeighborWalls(walls, start);
		//		Pick a cell, mark it as part of the maze. Add the walls of the cell to the wall list.
		while(walls.Count > 0) {
			//Pick a random wall from the list. 
			//			int wall_num = rnd.Next(walls.Count);
			int wall_num = UnityEngine.Random.Range(0,walls.Count-1);
			Coord rnd_wall = walls[wall_num];
			//				Coord rnd_wall = new Coord(3,1);
			List<Coord> neighbors = get4Neighbors(rnd_wall);
			if (only1Visited(neighbors, visited)) {//If only one of the two cells that the wall divides is visited, then:
				//Make the wall a passage and mark the unvisited cell as part of the maze.
				Coord passage = getPassageCoord(rnd_wall);
				if (passage == null) {
					walls.RemoveAt(wall_num);
					continue;
				}
				visited.Add(passage);
				maze[passage.x, passage.y] = Square.PATH;
				visited.Add(rnd_wall);
				maze[rnd_wall.x, rnd_wall.y] = Square.PATH;

				//Add the neighboring walls of the cell to the wall list.
				walls = addNeighborWalls(walls, passage);
				//				walls = addNeighborWalls(walls, rnd_wall);
			}
			//Remove the wall from the list.
			walls.RemoveAt(wall_num);
		}
	}

	List<Coord> addNeighborWalls(List<Coord> walls, Coord center) {
		List<Coord> neighbors = get4Neighbors(center);
		List<Coord> result = new List<Coord>();
		foreach (Coord c in neighbors) {
			if (maze[c.x, c.y] == Square.WALL && !hasCoord(walls, c)) {
				result.Add(c);
			}
		}
		walls.AddRange(result);
		return walls;
	}

	List<Coord> get8Neighbors(Coord center) {
		int x = center.x;
		int y = center.y;
		List<Coord> result = new List<Coord> ();
		//N
		if (y < width - 1)
			result.Add(new Coord (x, y+1));
		//NE
		if (y < width - 1 && x < length - 1)
			result.Add(new Coord (x+1, y+1));
		//E
		if (x < length - 1)
			result.Add(new Coord (x+1, y));
		//SE
		if (y > 0 && x < length - 1)
			result.Add(new Coord (x+1, y-1));
		//S
		if (y > 0)
			result.Add(new Coord (x, y-1));
		//SW
		if (y > 0 && x > 0)
			result.Add(new Coord (x-1, y-1));
		//W
		if (x > 0)
			result.Add(new Coord (x-1, y));
		//NW
		if (y < width - 1 && x > 0)
			result.Add(new Coord (x-1, y+1));
		return result;
	}

	List<Coord> get4Neighbors(Coord center) {
		int x = center.x;
		int y = center.y;
		List<Coord> result = new List<Coord> ();
		//N
		if (y < width - 1)
			result.Add(new Coord (x, y+1));
		//E
		if (x < length - 1)
			result.Add(new Coord (x+1, y));
		//S
		if (y > 0)
			result.Add(new Coord (x, y-1));
		//W
		if (x > 0)
			result.Add(new Coord (x-1, y));
		return result;
	}

	bool only1Visited(List<Coord> neighbors, List<Coord> visited) {
		int matches = 0;
		foreach (Coord c1 in neighbors) {
			//			if (c1.x == 0 || c1.y == 0 || c1.x == length - 1 || c1.y == width - 1) return false;
			foreach (Coord c2 in visited) {
				if (c1.x == c2.x && c1.y == c2.y) {
					matches += 1;
				}
			}
		}
		if (matches == 1)
			return true;
		return false;
	}

	Coord getPassageCoord(Coord center) {
		Coord result = null;
		List<Coord> neighbors = get4Neighbors(center);
		foreach (Coord path in neighbors) {
			if (maze[path.x,path.y] == Square.PATH) {
				if (path.x == center.x) {
					if (path.y > center.y && center.y - 1 > 0) {
						result = new Coord (path.x, center.y - 1);
					} 
					else if (center.y + 1 < width-1) {
						result = new Coord (path.x, center.y + 1);
					}
				}
				else {
					if (path.x > center.x && center.x-1 > 0) {
						result = new Coord(center.x-1,path.y);
					}
					else if (center.x+1 < length-1) {
						return new Coord (center.x+1, path.y);
					}
				}
			}
		}
		if (result == null || result.x == 0 || result.y == 0 || result.x >= length-1 || result.y >= width-1) {
			return null;
		}
		return result;
	}
					
}
