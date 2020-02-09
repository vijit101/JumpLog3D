using LogJump.Log;
using System;
using UnityEngine;
namespace LogJump.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerView : MonoBehaviour
    {
        PlayerController playerController;
        public PlayerViewType playerViewType;
        [HideInInspector]
        public float jumpForce,horizontalStep;
        Rigidbody rgbd;
        private float offsetX;
        private LogView log;
        [HideInInspector]
        public bool isMove = true, isMoveWithPlatform = false;
        private void OnCollisionEnter(Collision collision)
        {
            log = collision.gameObject.GetComponent<LogView>();           
            if (log !=null)
            {
                offsetX = (transform.position.x - log.transform.position.x);
                isMove = true;
                isMoveWithPlatform = true;
            }
        }
        
        private void LateUpdate()
        {
            if (isMoveWithPlatform)
            {
                Vector3 pos = log.transform.position;
                pos.x = pos.x + offsetX;
                transform.position = pos;
            }
        }
        private void Awake()
        {
            rgbd = gameObject.GetComponent<Rigidbody>();
        }
        // Update is called once per frame
        private void Update()
        {
            OnFall();
            //MoveWithPlatform();
        }

        private void OnFall()
        {
            if (transform.position.y < 0)
            {
                Destroy(gameObject);
            }
        }

        public void SetMyController(PlayerController controller)
        {
            playerController = controller;
        }
        public void SetPlayerViewType(PlayerViewType viewType)
        {
            playerViewType = viewType;
        }
        public void SetPlayerPos(Vector3 transformPosition)
        {
            transform.position = transformPosition;
        }
        public void MovePlayer()
        {
            if (isMove)
            {
                if (playerViewType == PlayerViewType.Player1)
                {
                    isMoveWithPlatform = false;
                    transform.position = new Vector3(transform.position.x, transform.position.y + .2f, transform.position.z);
                    rgbd.AddForce(new Vector3(0, jumpForce, horizontalStep), ForceMode.Impulse);
                    isMove = false;                    
                }
                if (playerViewType == PlayerViewType.Player2)
                {
                    isMoveWithPlatform = false;
                    transform.position = new Vector3(transform.position.x, transform.position.y + .2f, transform.position.z);
                    rgbd.AddForce(new Vector3(0, jumpForce, -horizontalStep), ForceMode.Impulse);
                    isMove = false;
                }

            }            
        }

    }
}
