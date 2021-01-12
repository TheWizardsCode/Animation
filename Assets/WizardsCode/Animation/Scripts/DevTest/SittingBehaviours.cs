using UnityEngine;
using UnityEngine.UI;

namespace WizardsCode.Animation.DevTest
{
    public class SittingBehaviours : MonoBehaviour
    {
        [Header("UI")]
        public Button sitButton;
        public Button standButton;

        [Header("Environment")]
        public Transform sitPosition;

        [Header("Animation")]
        public Animator animator;
        public HumanoidController controller;

        public void OnSit() {
            controller.Sit(sitPosition);
        }

        public void OnStand() {
            controller.Stand();
        }
    }
}
