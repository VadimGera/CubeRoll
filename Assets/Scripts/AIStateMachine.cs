using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class AIStateMachine : MonoBehaviour
    {
        private AiState _currentState;
        private CubeController _cubeController;

        private void Start()
        {
            _currentState = new WanderState();
            _cubeController = GetComponent<CubeController>();
        }

        private void Update()
        {
            var direction = _currentState.GetDirection();
            _cubeController.Move(direction);
        }
    }

    public abstract class AiState
    { 
        public abstract Vector3 GetDirection();
    }

    public class WanderState : AiState
    {
        public override Vector3 GetDirection()
        {
            return Vector3.forward;
        }
    }
}