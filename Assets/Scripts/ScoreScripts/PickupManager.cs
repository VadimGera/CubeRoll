using System;
using DefaultNamespace.Ui;
using UnityEngine;

namespace DefaultNamespace
{
    public class PickupManager : SingletonMonoBehaviour<PickupManager>
    {
        [SerializeField] private int _currentPlayerAmount;
        [SerializeField] private AnimatedScoreDisplay _scoreDisplay;

        private void Start()
        {
            _scoreDisplay.Set(_currentPlayerAmount);
        }

        public void AddMoney(int amount)
        {
            _scoreDisplay.Animate(_currentPlayerAmount, _currentPlayerAmount + amount);
            
            _currentPlayerAmount += amount;
        }
    }
}