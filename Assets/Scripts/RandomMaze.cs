using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMaze : Maze {

	override public void Algorithm() {
		//		addEntrance();
		//		addExit();
		//		while (!allPathsAreReachable() || !isSolvable()){	// || wall_path_ratio() < 2.0) {
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				//				if (rnd.Next(2) == 0) {
				if (UnityEngine.Random.Range(0,2) == 0) {
					maze[i,j] = Square.WALL;
				}
			}
		}
//		addEntrance();
//		addExit();
		//		}
	}

}
