using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootScript : MonoBehaviour
{
    public bool enter;
    public AudioSource timanttiMp3;
    //int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        timanttiMp3 = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            //Debug.Log("Timantti löydetty! Etsi kunnes löydät niitä 5."); //debug teksti
            enter = true;
            // Play the sound only on the trigger
            if (enter) //(enter && count = 1)
            {
                timanttiMp3.Play();
                //count -= 1;
                Debug.Log("Äänimerkki");
            }
            //timanttiMp3.Play();
           
            this.gameObject.SetActive(false);
            DiamCounter.instance.KerasinTimantin(); //laskuri
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
