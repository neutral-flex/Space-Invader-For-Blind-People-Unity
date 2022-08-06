using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinPage;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Canvas = GameObject.Find("Canvas");
        WinPage = Canvas.transform.Find("Win Page").gameObject;

        StaticsCounter.instance.GameIsOver = true;
        WinPage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
