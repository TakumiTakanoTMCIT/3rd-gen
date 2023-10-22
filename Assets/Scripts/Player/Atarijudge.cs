using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atarijudge : MonoBehaviour
{
    //private bool isGround , onEnemy;

    public GameObject PlayerCon;
    PlayerCon pcon;

    // Start is called before the first frame update
    void Start()
    {
        //onEnemy = false;
        //isGround = false;
        PlayerCon = GameObject.Find("Player");

        pcon = PlayerCon.GetComponent<PlayerCon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "EUp")
        {
            Debug.Log("�G���^�[");
            pcon.OnGround(col);
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "EUp")
        {
            Debug.Log("�X�e�C");
            pcon.OnGround(col);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "EUp")
        {
            Debug.Log("�C�O�W�b�g");
            pcon.OnGround(col);
        }
    }
}
