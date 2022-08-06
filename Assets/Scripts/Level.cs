using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public int LevelNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenLevel()
    {
        SceneManager.LoadScene("Level" + LevelNumber);
    }public void OpeNmAINmENU()
    {
        SceneManager.LoadScene(0);
    }
}
