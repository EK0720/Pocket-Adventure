using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class itemCollector : MonoBehaviour
{
    private int Gold = 0;

    [SerializeField] private TextMeshProUGUI GoldText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            Gold++;
            GoldText.text = "Gold: " + Gold.ToString();        }
    }
}
