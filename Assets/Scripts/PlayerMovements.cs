using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovements : MonoBehaviour
{
        //referenssit:
        public Rigidbody pelaajaRB;
        float hyppyVoima;
        public float syoteVertical;
        private float pelaajaNopeus = 15f; //hidastettu


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
       
        //ota talteen painaako pelaaja oikealle tai vasemmalle (-1f t�ysi� vasemmalle, 1f t�ysi� oikealle)
            float syoteHorizontal = Input.GetAxis("Horizontal");
            float syoteVertical = Input.GetAxis("Vertical");

        //muuta pelaajan liikkuvuus nopeus x-akselilla vastaamaan pelaajan sy�tett�
       
        pelaajaRB.velocity = new Vector3(syoteHorizontal * pelaajaNopeus, pelaajaRB.velocity.y, syoteVertical * pelaajaNopeus); 

        //pallo pomppaa m-kirjaimesta //�ff�t on flowting pointteja space
        if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Pelaaja painoi space-nappia");
                pelaajaRB.AddForce(new Vector3(0f, hyppyVoima, 0f)); 
            }

        }
}
