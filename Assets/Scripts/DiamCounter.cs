using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamCounter : MonoBehaviour
{
    public TextMeshProUGUI laskuriLabel;
    private int timantit = 0;
    // Start is called before the first frame update
 
    public static DiamCounter instance;
    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    public void KerasinTimantin()
    {
        timantit++;
        laskuriLabel.text = "Kerättyjä timantteja: " + timantit.ToString();
    }
}
