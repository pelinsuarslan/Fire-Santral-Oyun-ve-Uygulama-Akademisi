using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class CoinCollesction : MonoBehaviour
{

    public TMP_Text _text;
    public int count=0;
    public GameObject _gameOver;
    public GameObject _fadePanel;



    private AudioSource click;

    private void Start()
    {
        click = GetComponent<AudioSource>();
    }

      private void OnTriggerEnter(Collider other)
      { 
    
        if (other.gameObject.CompareTag("coin"))
            {
            count++;
            _text.text = count.ToString();
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            click.Play();
            if (count == 15)
            {
                _gameOver.SetActive(true);
                _fadePanel.SetActive(true);
                StartCoroutine(Fade()); 
            }

        }
   
      }


    IEnumerator Fade()
    {
        yield return new WaitForSeconds(1.6f);
        Time.timeScale = 0;
    }
}
