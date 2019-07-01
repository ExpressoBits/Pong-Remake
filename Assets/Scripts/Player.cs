using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pong
{
    public class Player : MonoBehaviour
    {

        public int points;


        public void IncrementPoints(){
            points++;
        }

        // Start is called before the first frame update
        void Start()
        {
            points = 0;
        }

        private void Update() {
            
        }

    }

}
