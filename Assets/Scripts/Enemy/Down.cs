using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public PlayerCon con;

    public void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Downがなにかに触れた");

        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("敵に触れました。死亡します");
            con.Death();

            //ああｄｆさｆ
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
