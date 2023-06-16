    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class DoorScript : MonoBehaviour
    {
        [SerializeField] GameObject LevelComplete;
        [SerializeField] AudioSource winSound;   
        
        private void OnCollisionEnter2D(Collision2D collision2D)
        {
            if (collision2D.gameObject.CompareTag("Player"))
            {
                collision2D.gameObject.SetActive(false);
                winSound.Play();
            }
            LevelComplete.SetActive(true);
        }
    }