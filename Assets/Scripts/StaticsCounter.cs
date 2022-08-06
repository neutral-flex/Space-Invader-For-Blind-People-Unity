using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StaticsCounter : MonoBehaviour
{
    public static StaticsCounter instance;
    public float killsCounter;
    public bool GameIsOver;
    public Text Kills;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        Kills.text = "" +killsCounter;
    }
  

}
