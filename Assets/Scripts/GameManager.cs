using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CatFight
{
	public static class GameManager : MonoBehaviour
	{
		public static float score;
		public static int difficulty;
		private ArrayList sequences;
		private KeyCode[] currentSequence;
		private int currentLength;
		// Use this for initialization
		void Start ()
		{
			score = 0.0f;
			difficulty = 0;
			sequences = new ArrayList ();
			KeyCode[] sequence1 = new KeyCode[]{KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D};
			sequences.Add(sequence1);
		}
	
		// Update is called once per frame
		void Update ()
		{
		
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
				sequence [i] = availKeyCodes [index];
			}
			return sequence;

		}


		
	}
}
