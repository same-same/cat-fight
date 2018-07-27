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
		private ArrayList sequences;
		private ArrayList currentInput;
		private KeyCode[] currentSequence;
		private int currentLength;




		// Use this for initialization
		private void Start ()
		{
			wKey = KeyCode.W;
			aKey = KeyCode.A;
			sKey = KeyCode.S;
			dkey = KeyCode.D;
			sequences = new ArrayList ();
			KeyCode[] sequence1 = new KeyCode[]{KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D};
			sequences.Add(sequence1);

		
		}

		//TODO
		private KeyCode[] generateSequence () {
			KeyCode[] availKeyCodes = sequences [GameManager.difficulty];

			if (GameManager.difficulty == 0) {
				currentLength = 4;
			} else {
				//TODO
			}
			KeyCode[] sequence = new KeyCode[currentLength];
			for (int i = 0; i < currentLength; i++) {
				int index = Random.Range (1, currentLength + 1);



			}
		
			
			
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
