using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private static int picked = 0;
    private static int all = 0;

    public GameObject canvas;
    public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        all = FindObjectsOfType<Pickup>().Length;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            picked++;
            if (picked == all)
            {
                canvas.SetActive(true);
                winText.SetActive(true);
            }
        }
    }
}
