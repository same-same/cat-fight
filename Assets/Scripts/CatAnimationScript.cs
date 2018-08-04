using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CatFight
{
    public class CatAnimationScript : MonoBehaviour {

        // Cat animation should listen to player's state
        // ex.  - if user matches the sequence perfectly (w/ easy sequences)
        //      - if user doesn't match a sequence in time (w/ easy)
        //      - if user matches the sequence perfectly (w/ medium sequences)
        //      - if user doesn't match a sequence in time (w/ medium) etc. etc.

        public Text subtitles;
        Animator animator;

        void Start() {
            animator = GetComponent<Animator>();
        }

        void Update() {
            //TODO: change event to listen to player's state

            // Trigger Sequence Win/Lose Animation
            if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                // fire trigger (trigger is found in Cat Prefab's Animation Controller)
                animator.SetTrigger("PlayerSequenceWin");
            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) {
                // fire trigger (trigger is found in Cat Prefab's Animation Controller)
                animator.SetTrigger("PlayerSequenceLose");
            }

            // Trigger difficulty change animations
            if (Input.GetKeyDown(KeyCode.M)) {
                animator.SetBool("EasyToMedium", true);
            }

            if (Input.GetKeyDown(KeyCode.H)) {
                animator.SetBool("MediumToHard", true);
            }

            // Trigger Game Win animation
            if (Input.GetKeyDown(KeyCode.UpArrow)) {
                // fire trigger (trigger is found in Cat Prefab's Animation Controller)
                animator.SetTrigger("PlayerGameWin");
            }
        }

        // note: primarily to pass Text object to StateMachineBehaviour
        public Text getSubtitles(){
            return subtitles;
        }
    }
}