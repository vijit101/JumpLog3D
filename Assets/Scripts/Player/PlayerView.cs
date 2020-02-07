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
        private void Awake()
        {
            rgbd = gameObject.GetComponent<Rigidbody>();
        }
        // Update is called once per frame
       
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
            if (playerViewType == PlayerViewType.Player1)
            {
                rgbd.AddForce(new Vector3(0, jumpForce, horizontalStep), ForceMode.Impulse);
            }
            if (playerViewType == PlayerViewType.Player2)
            {
                rgbd.AddForce(new Vector3(0, jumpForce, -horizontalStep), ForceMode.Impulse);
            }
            
        }
    }
}
