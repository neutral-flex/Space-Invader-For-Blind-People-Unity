using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script defines which sprite the 'Player" uses and its health.
/// </summary>

public class Player : MonoBehaviour
{
    public GameObject destructionFX;
    public GameObject GameOver;

    public static Player instance;
    public AudioSource dIEsOUND;
    public Text livesCounter;
    public int Damage;
    float Timer;
    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }

    //method for damage proceccing by 'Player'
    public void GetDamage(int damage)   
    {
       
      
      
    }
    private void Update()
    {
        livesCounter.text = Damage.ToString();
        if (Damage <= 0)
        {
            dIEsOUND.Play();
            Destruction();
            
        }
    }
    //'Player's' destruction procedure
    void Destruction()
    {
        Instantiate(destructionFX, transform.position, Quaternion.identity); //generating destruction visual effect and destroying the 'Player' object
        Instantiate(GameOver, transform.position, Quaternion.identity);
        StaticsCounter.instance.GameIsOver = true;
        //generating destruction visual effect and destroying the 'Player' object
        Destroy(gameObject);
    }
}
















