using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pong
{
    public class GameManager : MonoBehaviour
    {

        public Player playerOne;
        public Player playerTwo;

        public Text player1Score;
        public Text player2Score;

        private AudioSource _audioSource;

        private void Awake() {
            _audioSource = GetComponent<AudioSource>();
        }

        // Start is called before the first frame update
        void Start()
        {
            UpdateUI();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void UpdateUI()
        {
            player1Score.text = playerOne.points + "";
            player2Score.text = playerTwo.points + "";
            _audioSource.Play();
        }

    }

}

