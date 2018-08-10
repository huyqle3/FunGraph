using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntAndKill : AlgorithmClass{
	public int cRow = 0;
	public int cColumn = 0;

	public int maxRows = 8, maxColumns = 8;

	private bool courseComplete = false;

	public HuntAndKill(MazeCell[,] mazeCells) : base(mazeCells) {
	}

	public static int currentPosition = 0;
	public const string key = "123424123342421432233144441212334432121223344";

	public static int GetNextNumber() {
		string currentNum = key.Substring(currentPosition++ % key.Length, 1);
		return int.Parse (currentNum);
	}

	public void clear(){		
		courseComplete = false;
		for(int i = 0; i < maxRows; i++){
			for(int j = 0; j < maxColumns; j++){
				mazeCells[i, j].visited = false;
				destroyWall(mazeCells[i, j].northWall);
				destroyWall(mazeCells[i, j].southWall);
				destroyWall(mazeCells[i, j].eastWall);
				destroyWall(mazeCells[i, j].northWall);
			}
		}
		cRow = 0;
		cColumn = 0;
	}
	
	public void run(int length, int width, bool render){
		maxRows = length;
		maxColumns = width;

		mazeCells [cRow, cColumn].visited = true;
		while (! courseComplete) {			
			kill();
			hunt(); 
		}
		if(courseComplete){
			render = true;
		}
	}

	private void kill(){
		while( isRoute(cRow, cColumn) ){
			int direction = Mathf.CeilToInt(UnityEngine.Random.Range(0.0f, 4.0f));
			if (direction == 1 && isAvailable (cRow- 1, cColumn)) {
				// North
				destroyWall (mazeCells [cRow, cColumn].northWall);
				destroyWall (mazeCells [cRow- 1, cColumn].southWall);
				cRow--;
			} else if (direction == 2 && isAvailable (cRow+ 1, cColumn)) {
				// South
				destroyWall (mazeCells [cRow, cColumn].southWall);
				destroyWall (mazeCells [cRow+ 1, cColumn].northWall);
				cRow++;
			} else if (direction == 3 && isAvailable (cRow, cColumn + 1)) {
				// east
				destroyWall(mazeCells [cRow, cColumn].eastWall);
				destroyWall (mazeCells [cRow, cColumn + 1].westWall);
				cColumn++;
			} else if (direction == 4 && isAvailable (cRow, cColumn - 1)) {
				// west
				destroyWall (mazeCells [cRow, cColumn].westWall);
				destroyWall(mazeCells [cRow, cColumn - 1].eastWall);
				cColumn--;
			}

			mazeCells[cRow, cColumn].visited = true;		
		}
	}

	private bool isAvailable(int row, int column) {
		if (row >= 0 && row < mazeRows && column >= 0 && column < mazeColumns && !mazeCells [row, column].visited) {
			return true;
		} else {
			return false;
		}
	}

	private void hunt(){
		courseComplete = true;
		
		for(int i = 0; i < maxRows; i++){
			for(int j = 0; j < maxColumns; j++){
				if (!mazeCells [i, j].visited && isRoute(i, j)) {
					courseComplete = false;
					cRow = i;
					cColumn = j;
					destroyAdjacentWall (cRow, cColumn);
					mazeCells [cRow, cColumn].visited = true;
					//					return;
				}
			}
		}	
	}
	
	private bool isRoute(int r, int c){
		int countVisited = 0;

		if(r > 0 && !mazeCells[r - 1, c].visited){
			countVisited += 1;
		}
		else if(r < maxRows - 1 && !mazeCells[r + 1, c].visited){
			countVisited += 1;
		}
		else if(c > 0 && !mazeCells[r, c - 1].visited){
			countVisited += 1;
		}
		else if(c < maxColumns - 1 && !mazeCells[r, c + 1].visited){
			countVisited += 1;			
		}
		return countVisited > 0;
	}

 	private void destroyWall(GameObject Wall){
		if(Wall != null){
			GameObject.Destroy(Wall);
		}
	}

	private void destroyAdjacentWall(int r, int c){
		bool wallDestroyed = false;

		while(!wallDestroyed){
			int direction = Mathf.FloorToInt(UnityEngine.Random.Range(0,4));
			if(direction == 1 && r > 0 && mazeCells[r - 1, c].visited){
				destroyWall(mazeCells[r, c].northWall);
				destroyWall(mazeCells[r-1, c].southWall);
				wallDestroyed = true;
			}
			else if(direction == 2 && r < maxRows - 2 && mazeCells[r + 1, c].visited){
				destroyWall(mazeCells[r, c].southWall);
				destroyWall(mazeCells[r+1, c].northWall);
				wallDestroyed = true;
			}
			else if(direction == 3 && c > 0 && mazeCells[r, c - 1].visited){
				destroyWall(mazeCells[r, c].eastWall);
				destroyWall(mazeCells[r, c-1].westWall);
				wallDestroyed = true;
			}
			else if(direction == 4 && c < maxColumns - 2 && mazeCells[r, c + 1].visited){
				destroyWall(mazeCells[r, c].westWall);
				destroyWall(mazeCells[r, c+1].eastWall);
				wallDestroyed = true;
			}
		}
	}

	public void destroyAllWalls(){
		GameObject.Destroy(GameObject.Find("Wall"));
	}
}
