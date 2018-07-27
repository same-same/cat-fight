using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CatFight
{
	public class UserInput : MonoBehaviour
	{
		public static float userScore;
		private KeyCode wKey;
		private KeyCode aKey;
		private KeyCode sKey;
		private KeyCode dkey;
		private KeyCode start;
		private KeyCode exit;
		private ArrayList currentInput;

		// Use this for initialization
		private void Start ()
		{
			wKey = KeyCode.W;
			aKey = KeyCode.A;
			sKey = KeyCode.S;
			dkey = KeyCode.D;		
		}
			
	
		// Update is called once per frame
		void Update ()
		{
		
		}

		private void increaseScore (float num)
		{
			GameManager.score += num;
		}

		//TODO
		private void endGame() {
			
		}

		//TODO
		private bool matchKey(KeyCode userKey, KeyCode requiredKey) {
			
		}

		//TODO
		private void startGame() {

		}







	}
}
