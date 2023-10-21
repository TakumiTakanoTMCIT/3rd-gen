using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atarijudge : MonoBehaviour
{
    private bool isGround;

    public GameObject PlayerCon;
    PlayerCon pcon;

    // Start is called before the first frame update
    void Start()
    {
        isGround = false;
        PlayerCon = GameObject.Find("Player");

        pcon = PlayerCon.GetComponent<PlayerCon>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGround)
        {
            pcon.OnGround();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("エンター");
        if (col.gameObject.CompareTag("Grounds") || col.gameObject.CompareTag("Object") || col.gameObject.CompareTag("Enemy"))
        {
            isGround = true;
            
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        //Debug.Log("ステイ");
        if (col.gameObject.CompareTag("Grounds") || col.gameObject.CompareTag("Object") || col.gameObject.CompareTag("Enemy"))
        {
            isGround = true;
            
        }    
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        //Debug.Log("イグジット");
        if (col.gameObject.CompareTag("Grounds") || col.gameObject.CompareTag("Object") || col.gameObject.CompareTag("Enemy"))
        {
            isGround = false;
            
        }
    }
}
