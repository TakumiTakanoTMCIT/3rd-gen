using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public PlayerCon con;

    public void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("DownÇ™Ç»Ç…Ç©Ç…êGÇÍÇΩ");

        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("ìGÇ…êGÇÍÇ‹ÇµÇΩÅBéÄñSÇµÇ‹Ç∑");
            con.Death();

            //Ç†Ç†ÇÑÇÜÇ≥ÇÜ
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
