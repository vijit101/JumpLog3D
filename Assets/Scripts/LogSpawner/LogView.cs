using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LogJump.Log
{
    public class LogView : MonoBehaviour
    {
        public float logMoveSpeed = 1;
        Rigidbody rgbd;
        private void Awake()
        {
            rgbd = gameObject.GetComponent<Rigidbody>();
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

        private void Update()
        {
            Vector3 pos = transform.position;
            pos.x += logMoveSpeed * Time.deltaTime;
            transform.position = pos;
        }
    }
}
