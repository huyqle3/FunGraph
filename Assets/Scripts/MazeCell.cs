using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MazeCell : MonoBehaviour {
       	public bool visited = false;
	public GameObject northWall, southWall, eastWall, westWall, floor;
}
