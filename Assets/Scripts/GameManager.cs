using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float timerlimit;
    public TMP_Text TimerText;
    public float Timer;
    public TMP_Text StarText;
    public float coin;
    private float var1;
    public float MinSpeed;



    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        Timer += Time.deltaTime;
        var1 = (coin*100) + (Timer*10);
        TimerText.text = ("Score: "+(var1.ToString("F1")));
        StarText.text = ("Stars: "+(coin.ToString("F0")));

        
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (GameObject.Find("Car").GetComponent<CarController>().ZVel <MinSpeed && GameObject.Find("Sphere").GetComponent<playercollider>().VelStart == 1)
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
