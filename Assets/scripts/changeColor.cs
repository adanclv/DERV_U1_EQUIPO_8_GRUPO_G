using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();   
    }

    // Update is called once per  PRACTICA 3
    void Update()
    {
        rend.material.color = Color.blue;
    }
}
