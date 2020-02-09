using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LogJump.Log
{
    public class LogView : MonoBehaviour
    {
        public float logMoveSpeed = 1;
        public bool isChangeLogSpeedAfterTime = false;
        float ChangeSpeedAfterTime = 2;
        public float minLogMoveSpeed, maxLogMoveSpeed,minChangeSpeedTime,maxChangeSpeedTime;
        Rigidbody rgbd;
        private float TimeLapsed;

        private void Awake()
        {
            rgbd = gameObject.GetComponent<Rigidbody>();
            SetRandomLogSpeed();
            SetRandomLogSpeed();
        }

        private void SetRandomLogSpeed()
        {
            logMoveSpeed = Random.Range(minLogMoveSpeed, maxLogMoveSpeed);
        }
        private void SetRandomChangeLogSpeedTime()
        {
            ChangeSpeedAfterTime = Random.Range(minChangeSpeedTime, maxChangeSpeedTime);
        }

        // Start is called before the first frame update
        void Start()
        {
            Destroy(gameObject, 10);
        }

        public void SetMyPos(Vector3 SpawnPos)
        {
            transform.position = SpawnPos;
        }

        public void SetLogXScale(float xScaleValue)
        {
            Vector3 scale = transform.localScale;
            scale.x = xScaleValue;
            transform.localScale = scale;
        }
        private void Update()
        {
            MoveLog();
            if (isChangeLogSpeedAfterTime)
            {
                if (TimeLapsed > ChangeSpeedAfterTime)
                {
                    TimeLapsed = 0;
                    SetRandomLogSpeed();
                    SetRandomChangeLogSpeedTime();
                }
                else
                {
                    TimeLapsed += Time.deltaTime;
                }
            }           
        }

        private void MoveLog()
        {
            Vector3 pos = transform.position;
            pos.x += logMoveSpeed * Time.deltaTime;
            transform.position = pos;
        }
    }
}
