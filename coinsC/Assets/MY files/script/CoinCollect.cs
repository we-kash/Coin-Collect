using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinCollect : MonoBehaviour
{
    public TextMeshProUGUI countText,wintext;
    public AudioSource CoinC;
    private int count;
    void Start()
    {
        CoinC = GetComponent<AudioSource>();
        count = 0;
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            other.gameObject.SetActive(false);
            CoinC.Play();
            count++;
            countText.text = "SCORE:" + count.ToString();
            if (count >= 31)
            {
                wintext.gameObject.SetActive(true);
            }
        }
    }
}
