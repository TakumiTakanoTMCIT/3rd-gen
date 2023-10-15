using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    public PlayerCon con;
    public EnemyCon Econ;
    public EnemyImage enemyImage;
    
    public void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("UPがなにかに触れた");

        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Playerに踏まれました死亡します");
            Econ.Death();

            GameObject enemymanager = GameObject.Find("EnemyDeathUIManager");
            enemymanager.GetComponent<EnemyImage>().Imaging();
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
