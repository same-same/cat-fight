using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace CatFight
{
	public class GameManager : MonoBehaviour
	{
		public static float score;
		public static int difficulty;
		private static List<KeyCode[]> sequences;
		public static KeyCode[] currentSequence;
		private static int currentLength;

        public Text generatedSequenceTextbox;

        private enum GeneratedSequenceStates { Waiting, New, Clear};
        private GeneratedSequenceStates CurrentGSState;

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

            CurrentGSState = GeneratedSequenceStates.New;
		}
	
		// Update is called once per frame
		void Update ()
		{
            if (CurrentGSState == GeneratedSequenceStates.New){
                // render
                renderSequenceOnTextbox(generatedSequenceTextbox, sequences[0]);

                // change to waiting
                CurrentGSState = GeneratedSequenceStates.Waiting;
            }
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
				int index = Random.Range (1, currentLength);
				sequence [i] = availKeyCodes [index];
			}
			return sequence;

		}

		public static void nextSequence() {
			currentSequence = generateSequence ();
           
		}

        public static void renderSequenceOnTextbox(Text textbox, KeyCode[] sequence){
            //textbox.text = sequence.ToString();
            StringBuilder sb = new StringBuilder();
            foreach(KeyCode letter in sequence){
                sb.Append(letter);
            }
            textbox.text = sb.ToString();
        }
		
	}
}
