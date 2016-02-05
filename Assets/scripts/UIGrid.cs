using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIGrid : MonoBehaviour {

	public static UIGrid instance;
	public int rows, cols;
	public Transform[,] locations; 
	public Yacker[,] yackers;
	
	// Use this for initialization
	void Awake () {
		instance = this;
		locations = new Transform[rows, cols];
		yackers = new Yacker[rows, cols];
		for(int x = 1; x <= rows; x++)
		{
			for(int y = 1; y <= cols; y++)
			{
				locations[x - 1,y - 1] = transform.FindChild( x + " - " + y);
			}
		}
	}
	
	public static UIGrid get() { return instance; }
	
	public Transform getPosition(int x, int y)
	{
		return locations[x,y];
	}
	
	//Yacker GETTER/SETTER
	public void setYacker(int x, int y, Yacker yack) {
		yackers[x, y] = yack;
	}
	public Yacker getYacker(int x, int y) {
		return yackers[x, y];
	}
	
	public void clear() {
		for(int x = 0; x < rows; x++)
		{
			for(int y = 0; y < cols; y++)
			{
				Destroy(yackers[x,y].gameObject);
			}
		}
	}
}
