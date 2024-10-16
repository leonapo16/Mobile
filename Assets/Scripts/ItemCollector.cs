using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private TextElement

    private int pineapples = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            Destroy(collision.gameObject);
            pineapples++;
            Debug.Log("Pineapples: " + pineapples);

        }
    }
}
