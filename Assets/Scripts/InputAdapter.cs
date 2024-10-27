using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAdapter : MonoBehaviour
{
    [SerializeField]
    private PlayerController controller;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        controller.Move(x * speed * Time.deltaTime, false, y > 0.1);
    }
}
