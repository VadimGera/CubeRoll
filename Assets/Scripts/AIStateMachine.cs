﻿/*using System;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(CubeController))]
    public class AIStateMachine : MonoBehaviour
    {
        private AiState _currentState;
        private CubeController _cubeController;

        private void Start()
        {
            _currentState = new WanderState(_startDirection);

            _cubeController = GetComponent<CubeController>();
        }

        private void Update()
        {
            var direction = _currentState.GetDirection(transform.position);

            _cubeController.Move(direction);

            _currentState.OnUpdate(Time.deltaTime);
            var newState = _currentState.GetNextState();
            if (newState != null)
            {
                _currentState = newState;
            }
        }
    }

}  */ 