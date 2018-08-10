using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMaker : MonoBehaviour {
       protected int width = 16, length = 16;
       public GameObject Wall;
       protected float size = 2f;
       public MazeCell[,] mazeCells;
       
	// Use this for initialization
	void Start() {
	     initMaze();
	     HuntAndKill hk = new HuntAndKill(mazeCells);
		 hk.run();
	     	     
	}

	// Update is called once per frame
	void Update () {

	}

	private void initMaze(){
		mazeCells = new MazeCell[length, width];

		for(int i = 0; i < length; i++){
			for(int j = 0; j < width; j++){
				mazeCells[i, j] = new MazeCell();
				mazeCells[i, j].floor = Instantiate (Wall, new Vector3 (i*size, -(size/2f), j*size), Quaternion.identity) as GameObject;				      mazeCells[i, j].floor.transform.Rotate(Vector3.right, 90f);			

				if (j == 0) {
				      mazeCells[i, j].westWall = Instantiate (Wall, new Vector3 (i*size, 0, (j*size) - (size/2f)), Quaternion.identity) as GameObject;
				      mazeCells [i, j].westWall.name = "West Wall " + i + "," + j;
				}

				mazeCells [i, j].eastWall = Instantiate (Wall, new Vector3 (i*size, 0, (j*size) + (size/2f)), Quaternion.identity) as GameObject;
				mazeCells [i, j].eastWall.name = "East Wall " + i + "," + j;

				if (i == 0) {
					mazeCells [i, j].northWall = Instantiate (Wall, new Vector3 ((i*size) - (size/2f), 0, j*size), Quaternion.identity) as GameObject;
					mazeCells [i, j].northWall.name = "North Wall " + i + "," + j;
					mazeCells [i, j].northWall.transform.Rotate (Vector3.up * 90f);
				}

				mazeCells[i, j].southWall = Instantiate (Wall, new Vector3 ((i*size) + (size/2f), 0, j*size), Quaternion.identity) as GameObject;
				mazeCells [i, j].southWall.name = "South Wall " + i + "," + j;
				mazeCells [i, j].southWall.transform.Rotate (Vector3.up * 90f);
			}
		}

	}
}
	
