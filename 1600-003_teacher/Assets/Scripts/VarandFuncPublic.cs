using UnityEngine;
using System.Collections;

public class VarandFuncPublic : MonoBehaviour 
{
	public int myInt = 1000;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		myInt = AddOne (myInt);
		Debug.Log (myInt);
	}
	int AddOne (int Number)
	{
		int ret;
		ret = Number + 1000;
		return ret;
	}
}
