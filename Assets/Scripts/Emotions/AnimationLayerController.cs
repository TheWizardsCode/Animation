#if SALSA
using CrazyMinnow.SALSA;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WizardsCode.Animation
{
    /// <summary>
    /// The AnimationlayerController configures the weights of layers in the Animator based on what the character
    /// is currently doing.
    /// </summary>
    public class AnimationLayerController : MonoBehaviour
    {
        [SerializeField, Range(0.1f, 4f), Tooltip("The duration of the transition from one weight to the next, if this is too short the animations will look jerky.")]
        float m_ChangeDuration = 4f;
        [SerializeField, Range(0, 1f), Tooltip("The weight for the layer used when the character is deemed to be talking.")]
        float m_TalkingLayerWieght = 1f;

        private Animator m_animator;
        private Salsa m_salsa;
        private float m_GoalWeight;
        private float m_ChangeProgress = 0;

        private const int TALKING_LAYER_INDEX = 1;

        private void Awake()
        {
            m_animator = GetComponentInParent<Animator>();
            m_salsa = GetComponent<Salsa>();
        }

        void Update()
        {
            if (m_animator.GetLayerWeight(TALKING_LAYER_INDEX) != m_GoalWeight)
            {
                m_ChangeProgress += Time.deltaTime;
            } else
            {
                m_ChangeProgress = 0;
            }

            if (isTalking)
            {
                m_GoalWeight = m_TalkingLayerWieght;
                m_animator.SetLayerWeight(TALKING_LAYER_INDEX, Mathf.Lerp(m_animator.GetLayerWeight(TALKING_LAYER_INDEX), m_GoalWeight, m_ChangeProgress / m_ChangeDuration));
            } else
            {
                m_GoalWeight = 0;
                m_animator.SetLayerWeight(TALKING_LAYER_INDEX, Mathf.Lerp(m_animator.GetLayerWeight(TALKING_LAYER_INDEX), m_GoalWeight, m_ChangeProgress / m_ChangeDuration));
            }
        }

        bool isTalking
        {
            get
            {
                return m_salsa.IsSALSAing;
            }
        }
    }
}
#endif