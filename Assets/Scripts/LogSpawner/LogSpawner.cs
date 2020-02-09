using System;
using UnityEngine;

namespace LogJump.Log
{
    public class LogSpawner : MonoBehaviour
    {
        public LogView logView;
        public float minLogSpawnTime,maxLogSpawnTime, spawnTime;
        float timeLapsed = 0;
        private void SetSpawnTime()
        {
            spawnTime = UnityEngine.Random.Range(minLogSpawnTime, maxLogSpawnTime);
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
        }
    }

}
