using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CatFight
{
	public static class GameManager : MonoBehaviour
	{
		public static float score;
		public static int difficulty;
		// Use this for initialization
		void Start ()
		{
			score = 0.0f;
			difficulty = 0;
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
		
	}
}
