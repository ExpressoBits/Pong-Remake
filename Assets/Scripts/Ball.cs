using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pong
{
    public class Ball : MonoBehaviour
    {

        public float initialForce = 200f;

        private Rigidbody2D _rigidBody2D;

        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }

        // Start is called before the first frame update
        void Start()
        {
            Init();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Init(){
            _rigidBody2D.velocity = Vector2.zero;
            _rigidBody2D.AddForce((Random.Range(0,2)==0?Vector2.left:Vector2.right) * initialForce);
            transform.position = Vector2.zero;
        }
    }

}

