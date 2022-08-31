using Paintastic.Utility;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Paintastic.Score;

namespace Paintastic.Scene.Gameplay
{
    public class Gameplay : MonoBehaviour
    {
        public static UnityAction OnGameplay;
        public static UnityAction<int, string> OnGameOver;
        public static UnityAction OnItemTimerEnd;

        [SerializeField] private Timer _gameTimer;
        [SerializeField] private Timer _playerOneTimer;
        [SerializeField] private Timer _playerTwoTimer;
        [SerializeField] private TMP_Text _remainingTime;

        private int _currentWinner;

        private string _winnerColor;

        private ScoreManager _scoreManager;

        private void Start()
        {
            _scoreManager = GetComponent<ScoreManager>();
            _gameTimer.OnTimerEnd += GameOver;
            _playerOneTimer.OnTimerEnd += DeactiveDoubleScore;
            _playerTwoTimer.OnTimerEnd += DeactiveDoubleScore;
            StartGame(); // placeholder, use Tutorial.OnGameplayStart when available
        }

        private void Update()
        {
            TimeSpan timeSpan;
            if (_gameTimer.GetIsRunning())
            {
                timeSpan = TimeSpan.FromSeconds(_gameTimer.GetRemainingTime() + 1);
            }
            else
            {
                timeSpan = TimeSpan.FromSeconds(0);
            }
            _remainingTime.text = "Remaining Time: " + timeSpan.ToString(@"m\:ss");
        }

        private void StartGame()
        {
            _gameTimer.StartTimer();
            OnGameplay?.Invoke();
        }

        private void GameOver(int x)
        {
            // TODO: change winner index from score and color
            OnGameOver?.Invoke(_currentWinner, _winnerColor);
        }



        private void PickupItem(string itemName, int player)
        {
            if (itemName == "CollectPoint")
            {
                CollectPoint(player);
            }
        }

        private void SpawnCollectPoint()
        {
            // TODO
        }

        private void SpawnBomb()
        {
            // TODO
        }

        private void CollectPoint(int player)
        {
            // TODO
        }

        public void PlayerTimer(int playerIndex)
        { 
            if(playerIndex == 0)
            {
                _playerOneTimer.StartTimer();
            }
            if(playerIndex == 1)
            {
                _playerTwoTimer.StartTimer();
            }
        }

        private void DeactiveDoubleScore(int playerIndex)
        {
            _scoreManager.DeactiveDoubleScore(playerIndex);
        }

        public void UpdateCurrentWinner(int playerIndex, string colorname)
        {
            _currentWinner = playerIndex;
            _winnerColor = colorname;
        }
    }

}