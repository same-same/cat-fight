﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CatFight
{
    public class CatAnimationScript : MonoBehaviour {

        // Cat animation should listen to player's state
        // ex.  - if user matches the sequence perfectly (w/ easy sequences)
        //      - if user doesn't match a sequence in time (w/ easy)
        //      - if user matches the sequence perfectly (w/ medium sequences)
        //      - if user doesn't match a sequence in time (w/ medium) etc. etc.

        Animator animator;

        void Start() {
            animator = GetComponent<Animator>();
        }

        void Update() {
            //TODO: change event to listen to player's state
            if (Input.GetKeyDown(KeyCode.Space)) {
                // fire trigger (trigger is found in Cat Prefab's Animation Controller)
                animator.SetTrigger("CatMeow");
            }
        }
    }
}