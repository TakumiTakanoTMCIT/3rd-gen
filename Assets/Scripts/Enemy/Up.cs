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
        //Debug.Log("UPÇ™Ç»Ç…Ç©Ç…êGÇÍÇΩ");

        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("ìGÇ…êGÇÍÇ‹ÇµÇΩÅBéÄñSÇµÇ‹Ç∑");
            con.Death();
        }
    }
}
