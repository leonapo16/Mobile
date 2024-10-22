
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text pineapplesText;
    [SerializeField] private AudioSource collectSuond;

    private int pineapples = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            collectSuond.Play();
            Destroy(collision.gameObject);
            pineapples++;
            pineapplesText.text = "Pineapples: " + pineapples;

        }
    }
}
