using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    public PlayerCon con;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("UPがなにかに触れた");

        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("敵に触れました。死亡します");
            con.Death();
        }
    }
}
