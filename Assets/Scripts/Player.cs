using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pong
{
    public class Player : MonoBehaviour
    {

        public int points;
        public float speed = 16f;
        public float forceUpDownBall = 256f;


        private Rigidbody2D _rigidBody2D;

        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }

        public void IncrementPoints()
        {
            points++;
        }

        // Start is called before the first frame update
        void Start()
        {
            points = 0;
        }

        private void FixedUpdate()
        {
            //_rigidBody2D.velocity = new Vector2(0, Input.GetAxis("Vertical") * speed);
            transform.position += Vector3.up * Input.GetAxis("Vertical");
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag == "Ball")
            {
                Debug.Log("SDAS");
                float y = other.gameObject.transform.position.y;
                if (y-0.5f > transform.position.y)
                {
                    other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * forceUpDownBall);
                }
                else if (y+0.5f < transform.position.y){
                    other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.down * forceUpDownBall);
                }
            }
        }

    }

}
