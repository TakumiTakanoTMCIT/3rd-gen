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
        Debug.Log("UP���Ȃɂ��ɐG�ꂽ");

        if (col.gameObject.CompareTag("ATARI"))// under of player
        {
            Debug.Log("Player�ɓ��܂�܂������S���܂�");
            Econ.Death();

            GameObject enemymanager = GameObject.Find("EnemyDeathUIManager");
            enemymanager.GetComponent<EnemyImage>().Imaging();
        }
    }

    /*public void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log("UP���Ȃɂ��ɐG�ꂽ");
        if (col.gameObject.CompareTag("Atari"))// under of player
        {
            Debug.Log("Player�ɓ��܂�܂������S���܂�");
            Econ.Death();

            GameObject enemymanager = GameObject.Find("EnemyDeathUIManager");
            enemymanager.GetComponent<EnemyImage>().Imaging();
        }
    }*/
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnDead()
    {
        Debug.Log("Player�ɓ��܂�܂������S���܂�");
        Econ.Death();

        GameObject enemymanager = GameObject.Find("EnemyDeathUIManager");
        enemymanager.GetComponent<EnemyImage>().Imaging();
    }

}
