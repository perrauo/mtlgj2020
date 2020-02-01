﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MTLGJ
{
     public class Session
    {
        [HideInInspector]
        public int Score = 0;

        [HideInInspector]
        public int Money = 0;

        [SerializeField]
        public float Lives = 10f;

        public healthbar hbar;

        public int WaveIndex = 0;

        public Wave Wave => GameResources.Instance.SessionSettings.Waves[WaveIndex];

        public Session()
        {
            Lives = GameResources.Instance.SessionSettings.MaxLives;
        }
    };

    public class Game : MonoBehaviour
    {
        public static Game Instance;
        
        public Session Session;

        private void Awake()
        {
            Instance = this;
        }

        private void Update() {
            hbar.SetSize(Health);

       
    }
}
}