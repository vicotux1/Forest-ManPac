using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

    public class Ball_move : MonoBehaviour
    {
        [SerializeField] private float m_MovePower = 5,m_MaxAngularVelocity = 25; 
        private const float k_GroundRayLength = 1f;
        public Vector3 Position_initial;
        private Rigidbody m_Rigidbody;

        void Update(){
            float MoveX=CrossPlatformInputManager.GetAxis("Horizontal");
            float MoveY=CrossPlatformInputManager.GetAxis("Vertical");
            Move(MoveX, MoveY);
            
        }
        private void Awake(){
            //Reset();
            m_Rigidbody = GetComponent<Rigidbody>();
            GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
        }
    public void Reset() {
    Cursor.visible = false;
    m_Rigidbody.velocity=Vector3.zero;
   transform.position=Position_initial;  
    }


    public void Move(float MoveZ, float MoveY){
    m_Rigidbody.AddTorque(new Vector3(MoveY, 0, -MoveZ)*m_MovePower);
        }
    }
