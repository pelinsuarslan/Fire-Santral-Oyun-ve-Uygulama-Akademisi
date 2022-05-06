using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrolu : MonoBehaviour
{
    
    public float speed = 5f;
    private void Update()
    {
        transform.Translate(0,0,1 * speed * Time.deltaTime);
        gameObject.GetComponent<Animator>().SetBool("isRunner",true);
    }
}