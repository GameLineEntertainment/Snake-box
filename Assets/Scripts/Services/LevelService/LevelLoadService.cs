﻿using System;
using UnityEngine;

namespace Snake_box
{
    public class LevelLoadService : Service
    {
        public event Action LevelLoaded;
        public event Action LevelUnloaded;

        private GameObject _currentLevel;

        public void LoadLevel(LevelType levelType)
        {
            if (_currentLevel != null)
            {
                GameObject.Destroy(_currentLevel);
                LevelUnloaded?.Invoke();
            }
            //_currentLevel = GameObject.Instantiate(Data.Instance.LevelData.GetPrefab(levelType));
            Services.Instance.LevelService.CurrentLevel = levelType;
            Services.Instance.LevelService.WaveCounterInc();
            Time.timeScale = 1;
            Debug.Log("invoke LevelLoaded");
            LevelLoaded?.Invoke();
            Services.Instance.EventService.WaveStart();
        }

        public void ReloadLevel() => LoadLevel(Services.Instance.LevelService.CurrentLevel);
    } 
}
