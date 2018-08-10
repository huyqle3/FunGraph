using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KruskalMaze : Maze {

	List<Coord> walls = new List<Coord>();
	List<HashSet<Coord>> sets = new List<HashSet<Coord>>();

	public void Go() {
		MakeFloor();
		Algorithm();
		PopulateMaze();
	}

	// Use this for initialization
	override public void Algorithm () {
		// 	Create a list of all walls, and create a set for each cell, each containing just that one cell.
		initFull();
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < width; j++) {
				HashSet<Coord> temp = new HashSet<Coord>();
				temp.Add(new Coord(i,j));
				sets.Add(temp);
				if (i % 2 == 1 && j % 2 == 1) {//only add odd walls
					walls.Add(new Coord(i,j));
				}
			}
		}
		List<int> wall_indexes = new List<int>();
		for (int i = 0; i < walls.Count; i++) {
			wall_indexes.Add(i);
		}
		ShuffleList(wall_indexes);

		//	For each wall, in some random order:
		foreach (int i in wall_indexes) {
			Coord center = walls[i];
			int x = center.x;
			int y = center.y;
			int vertical = UnityEngine.Random.Range(0, 1);
			//	If the cells divided by this wall belong to distinct sets:
			Coord one = null;
			Coord two = null;
			if (vertical == 1) {
				if (x > 0) {
					two = new Coord(x-1,y);
				}
				if (x < length - 1) {
					one = new Coord(x+1,y);
				}
				if (one != null && two != null && DistinctSets(one, two)) {
					//	Remove the current wall.
					walls.RemoveAt(i);//concurrent error?
					maze[center.x,center.y] = Square.PATH;
					maze[one.x,one.y] = Square.PATH;
					maze[two.x,two.y] = Square.PATH;
					//	Join the sets of the formerly divided cells.
					HashSet<Coord> set1 = GetSet(one);
					HashSet<Coord> set2 = GetSet(two);
					set1.UnionWith(set2);
					sets.Remove(set2);
				}
			}
			else {
				if (y > 0) {
					two = new Coord(x,y-1);
				}
				if (y < width - 1) {
					one = new Coord(x,y+1);
				}
				if (one != null && two != null && DistinctSets(one, two)) {
					//	Remove the current wall.
					walls.RemoveAt(i);//concurrent error?
					maze[center.x,center.y] = Square.PATH;
					maze[one.x,one.y] = Square.PATH;
					maze[two.x,two.y] = Square.PATH;
					//	Join the sets of the formerly divided cells.
					HashSet<Coord> set1 = GetSet(one);
					HashSet<Coord> set2 = GetSet(two);
					set1.UnionWith(set2);
					sets.Remove(set2);
				}
			}
		}
	}

	public bool DistinctSets(Coord c1, Coord c2) { 
		HashSet<Coord> set1 = GetSet(c1);
		HashSet<Coord> set2 = GetSet(c2);
		if (set1.Equals(set2)) {
			return false;
		}
		return true;
	}

	public HashSet<Coord> GetSet(Coord c) { 
		foreach (HashSet<Coord> set in sets) {
			if (hasCoord(set,c)) {
				return set;
			}
		}
		return null;
	}

	public void ShuffleList(List<int> list) {  
		int n = list.Count;  
		while (n > 1) {  
			n--;  
			int k = UnityEngine.Random.Range(0, n);  
			int value = list[k];  
			list[k] = list[n];  
			list[n] = value;  
		}  
	}


}
	
















