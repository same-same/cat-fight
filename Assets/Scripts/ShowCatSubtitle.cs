using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CatFight {
    public class ShowCatSubtitle : StateMachineBehaviour
    {
        private Text subtitles;

        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (subtitles == null) {
                // GameObjects can't be linked explicitly to StateMachineBehaviours like in MonoBehaviours 
                subtitles = animator.gameObject.GetComponent<CatAnimationScript>().getSubtitles();
            }
            showSubtitles(true);
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //
        //}

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (subtitles != null) {
                showSubtitles(false);
            }
        }

        // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
        //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //
        //}

        // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
        //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //
        //}

        void showSubtitles(bool b) {
            Color c = subtitles.color;

            // it wouldn't let me use ternaries OTL
            if (b && c != null) {
                c.a = 1;
            } else {
                c.a = 0;
            }

            subtitles.color = c;

        }
    }
}