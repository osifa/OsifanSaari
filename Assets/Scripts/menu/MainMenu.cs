using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 
    public void PlayGame()
    {
        //SceneManager.LoadScene("GameScene");
        Debug.Log("Aloita peli");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void EndGame()
    {
        //Application.Quit();
        Debug.Log("Sulje peli");
    }
}
