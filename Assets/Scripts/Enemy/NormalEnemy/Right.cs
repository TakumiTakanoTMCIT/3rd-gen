using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    public EnemyCon Econ;
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
        if (col.gameObject.CompareTag("Player"))
        {
            con.Death();
        }

        if (col.gameObject.CompareTag("Object"))
        {
            //Debug.Log("Rightに触れました");
            Econ.OnRight();
        }
    }
}
