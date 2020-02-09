using System;
using UnityEngine;

namespace LogJump.Log
{
    public class LogSpawner : MonoBehaviour
    {
        public LogView logView;
        public float minLogSpawnTime,maxLogSpawnTime, spawnTime;
        public float minLogScaleX, maxLogScaleX;
        [Tooltip("Set True if you want the first spawn time be random")]
        public bool isRandomSpawnTime;
        float timeLapsed = 0;

        private void Start()
        {
            if (isRandomSpawnTime)
            {
                SetSpawnTime();
            }
        }
        private void Update()
        {
            if (timeLapsed > spawnTime)
            {
                SpawnLog();
                timeLapsed = 0;
                SetSpawnTime();
            }
            else
            {
                timeLapsed += Time.deltaTime;
            }
            
        }

        private void SpawnLog()
        {
            LogView view = GameObject.Instantiate<LogView>(logView);
            view.SetMyPos(transform.position);
            float randomXScale = UnityEngine.Random.Range(minLogScaleX, maxLogScaleX);
            view.SetLogXScale(randomXScale);
        }

        

        private void SetSpawnTime()
        {
            spawnTime = UnityEngine.Random.Range(minLogSpawnTime, maxLogSpawnTime);
        }
    }

}
