using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{

    public Canvas main;



    // Start is called before the first frame update
    void Start()
    {
        main.enabled = true;
      
    }
    public void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
    public void OnReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
