using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello, world");
        
    }

    private void Awake()
    {
        print("Hello, awake");

    }

    // Update is called once per frame
    void Update()
    {
       // print(frame++);
    }

    void FixedUpdate()
    {
       // print(frame++);
    }

    private void OnMouseDown()
    {
        print("click");
    }
}
