using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timerlimit;
    public float Timer;
    public TMP_Text TimerText;
    public float coin;
    private float var1;


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        Timer += Time.deltaTime;
        var1 = (coin*100) + (Timer*10);
        TimerText.text = ("Score:"+(var1.ToString("F1")));

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
