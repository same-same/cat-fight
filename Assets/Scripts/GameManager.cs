using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CatFight
{
	public class GameManager : MonoBehaviour
	{
		public static float score;
		public static int difficulty;
		private static List<KeyCode[]> sequences;
		public static KeyCode[] currentSequence;
		private static int currentLength;
		// Use this for initialization
		void Start ()
		{
			score = 0.0f;
			difficulty = 0;
			sequences = new List<KeyCode[]> ();
			KeyCode[] difficulty0 = new KeyCode[]{KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D};
			sequences.Add(difficulty0);
			currentSequence = generateSequence ();
			Debug.Log (currentSequence);
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}

		//TODO
		private static KeyCode[] generateSequence () {
			KeyCode[] availKeyCodes = sequences[0];

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

		public static void nextSequence() {
			currentSequence = generateSequence ();

		}


		
	}
}
