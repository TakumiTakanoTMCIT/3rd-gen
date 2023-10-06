using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
    public EnemyCon con;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

        }

        if(col.gameObject.CompareTag("Object"))
        {
            Debug.Log("LeftÇ…êGÇÍÇ‹ÇµÇΩ");
            con.OnLeft();
        }
    }
}
