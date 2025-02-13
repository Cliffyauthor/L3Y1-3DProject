using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOver : MonoBehaviour
{

    public Canvas main;
    public TMP_Text ScoreDis;
    public float Score;
    public TMP_Text StarDis;
    public float Star;




    // Start is called before the first frame update
    void Start()
    {

        main.enabled = true;
        StarDis.text = ("Stars: "+(Star.ToString("F0")));
        ScoreDis.text = ("Score: "+(Score.ToString(("F0"))));
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
