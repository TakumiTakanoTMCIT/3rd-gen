using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownJump : MonoBehaviour
{
    public PlayerCon con;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player touched enemy");
            con.Death();
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
