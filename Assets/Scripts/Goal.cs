using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Pong
{
    public class Goal : MonoBehaviour
    {

        public UnityEvent eventOnBallCollider;
        public Ball ball;


        private void Start() {
            eventOnBallCollider.AddListener(delegate { ball.Init(); });
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if(other.gameObject.tag == ball.tag){
                eventOnBallCollider.Invoke();
            }
        }
    }
}

