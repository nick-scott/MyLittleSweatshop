using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{


	public PlayerResource playerResources;

	public float workRate = 1;

	private DateTime dateDelta;

	// Use this for initialization
	void Start ()
	{
		dateDelta = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update ()
	{
		DateTime now = DateTime.Now;
		if (dateDelta.AddSeconds(1/workRate) < now)
		{
			dateDelta = now;
			playerResources.increaseResouce(1);
		}
	}
}
