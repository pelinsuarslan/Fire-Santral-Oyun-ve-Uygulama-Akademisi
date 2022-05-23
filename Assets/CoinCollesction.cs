using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinCollesction : MonoBehaviour
{
    private AudioSource click;

    private void Start()
    {
        click = GetComponent<AudioSource>();
    }

      private void OnTriggerEnter(Collider other)
      { 
    
        if (other.gameObject.CompareTag("coin"))
            {
            Destroy(other.gameObject);
            click.Play();

            }
   
      }
}
