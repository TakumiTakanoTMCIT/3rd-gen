using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpJump : MonoBehaviour
{
    public EnemyCon Econ;

    public void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("UPがなにかに触れた");

        if (col.gameObject.name == "Atari")// under of player
        {
            Debug.Log("Playerに踏まれました死亡します");
            Econ.Death();
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
