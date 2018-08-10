using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntAndKill : AlgorithmClass{
	public int currentRow = 0;
	public int currentColumn = 0;

	private int maxRows, maxColumns;

	private bool courseComplete = false;

	public HuntAndKill(MazeCell[,] mazeCells) : base(mazeCells) {
	}
	
	public void run(){
		maxRows = mazeCells.Length;
		maxColumns = maxRows;
		
		//Set the [0,0] as visited 
		mazeCells [currentRow, currentColumn].visited = true;
		while (! courseComplete) {			
			Debug.Log('a');
			kill();
			Debug.Log('c');
			hunt(); 
		}
	}

	private void kill(){
		while( isRoute(currentRow, currentColumn) ){
			int direction = Mathf.FloorToInt(UnityEngine.Random.Range(0,4));

			if( direction == 0 && mazeCells[currentRow - 1, currentColumn].visited ){
				destroyWall( mazeCells[currentRow, currentColumn].northWall);
				destroyWall( mazeCells[currentRow - 1, currentColumn].southWall);							 
				currentRow--;
			}
			else if( direction == 1 && mazeCells[currentRow + 1, currentColumn].visited ){
				destroyWall( mazeCells[currentRow, currentColumn].southWall);
				destroyWall( mazeCells[currentRow + 1, currentColumn].northWall);
				currentRow++;
			}
			else if( direction == 2 && mazeCells[currentRow, currentColumn - 1].visited ){
				destroyWall( mazeCells[currentRow, currentColumn].eastWall);
				destroyWall( mazeCells[currentRow, currentColumn - 1].westWall);
				currentColumn--;
			}
			else if( direction == 3 && mazeCells[currentRow, currentColumn + 1].visited ){
				destroyWall( mazeCells[currentRow, currentColumn].westWall);
				destroyWall( mazeCells[currentRow, currentColumn + 1].eastWall);
				currentColumn++;
		    }
			mazeCells[currentRow, currentColumn].visited = true;		
		}
	}

	private void hunt(){
		courseComplete = true;
		
		for(int i = 0; i < maxRows; i++){
			for(int j = 0; j < maxColumns; j++){
				Debug.Log('b');
				if (!mazeCells [i, j].visited && isRoute(i, j)) {
					courseComplete = false;
					currentRow = i;
					currentColumn = j;
					destroyAdjacentWall (currentRow, currentColumn);
					mazeCells [currentRow, currentColumn].visited = true;
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
		else if(r < maxRows && !mazeCells[r + 1, c].visited){
			countVisited += 1;
		}
		else if(c > 0 && !mazeCells[r, c - 1].visited){
			countVisited += 1;
		}
		else if(c < maxColumns && !mazeCells[r, c + 1].visited){
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
			if(direction == 0 && r > 0 && mazeCells[r - 1, c].visited){
				destroyWall(mazeCells[r, c].northWall);
				destroyWall(mazeCells[r-1, c].southWall);
				wallDestroyed = true;
			}
			else if(direction == 1 && r < maxRows - 2 && mazeCells[r + 1, c].visited){
				destroyWall(mazeCells[r, c].southWall);
				destroyWall(mazeCells[r+1, c].northWall);
				wallDestroyed = true;
			}
			else if(direction == 2 && c > 0 && mazeCells[r, c - 1].visited){
				destroyWall(mazeCells[r, c].eastWall);
				destroyWall(mazeCells[r, c-1].westWall);
				wallDestroyed = true;
			}
			else if(direction == 3 && c < maxColumns - 2 && mazeCells[r, c + 1].visited){
				destroyWall(mazeCells[r, c].westWall);
				destroyWall(mazeCells[r, c+1].eastWall);
				wallDestroyed = true;
			}
		}
	}
}
