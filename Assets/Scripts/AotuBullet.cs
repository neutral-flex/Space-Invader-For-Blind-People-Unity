using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AotuBullet : MonoBehaviour
{
    public GameObject myBullet;
    public float Timer;
    public float DelayInBullets;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= DelayInBullets)
        {
            Attack();
            Timer = 0;
        }
    }
    public void Attack()
    {
        Instantiate(myBullet, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }
}
