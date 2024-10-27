using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    public GameObject canvas;
    public GameObject killText;

    private void Start()
    {
        canvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.CompareTag("Player"))
        {
            canvas.SetActive(true);
            killText.SetActive(true);
        }
        Destroy(transform.parent.gameObject);
    }
}
