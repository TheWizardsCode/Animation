using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace threeDTBD.Animation
{
    /// <summary>
    /// Converts NavMesh movement to animation controller parameters.
    /// </summary>
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(NavMeshAgent))]
    public class SimpleLocomotionController : MonoBehaviour
    {
        [SerializeField, Tooltip("The name of the parameter in the animator that sets the forward speed of the character.")]
        private string SpeedParameterName = "Forward";
        [SerializeField, Tooltip("The name of the parameter in the animator that sets the turn angle of the character.")]
        private string TurnParameterName = "Turn";

        private Animator m_Animator;
        private NavMeshAgent m_Agent;
        private float m_RunningSpeed = 8;

        protected virtual void Start()
        {
            m_Animator = GetComponent<Animator>();
            m_Agent = GetComponent<NavMeshAgent>();
        }

        protected virtual void Update()
        {
            if (m_Animator != null && m_Agent != null)
            {
                m_Animator.SetFloat(SpeedParameterName, m_Agent.desiredVelocity.magnitude / m_RunningSpeed);

                Vector3 s = m_Agent.transform.InverseTransformDirection(m_Agent.velocity).normalized;
                float turn = s.x;
                m_Animator.SetFloat(TurnParameterName, turn);
            }
        }
    }
}
