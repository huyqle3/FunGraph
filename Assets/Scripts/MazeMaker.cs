using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMaker : MonoBehaviour {


	// Use this for initialization
	void Start() {
		//length = UnityEngine.Random.Range(5,50);
		//width = UnityEngine.Random.Range(5,50);
		//height = UnityEngine.Random.Range(1,8);

//		MakeFloor();
//		MakeBorders();
//		RandomMaze();
		PrimMaze maze = new PrimMaze();
        //		KruskalMaze maze = new KruskalMaze();
		maze.Go();

//		PopulateMaze();
//		DrawMaze();
	}

	// Update is called once per frame
	void Update () {

	}

}
