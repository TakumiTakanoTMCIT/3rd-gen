using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharaCon : MonoBehaviour
{
    GameObject MoveChara;
    Transform TF;
    private bool AtBG = true;
    Vector3 tra;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Thefirst", 1); //1ïbåoÇ¡ÇΩÇÁé¿çsÇ∑ÇÈ
    }

    void Thefirst()
    {
        MoveChara = GameObject.Find("MoveChara");
        TF = MoveChara.transform;
        tra = TF.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = TF.position;

        if ( AtBG )
        {
                //Debug.Log("Canmove");
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    pos.x += 1;
                    //Debug.Log("Rightcannnn");
                }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                pos.x -= 1;
                //Debug.Log("Left");
            }
        }
        TF.position = pos;  // ç¿ïWÇê›íË
        Debug.Log(tra);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        TF.position = tra;
        AtBG = true;
        //Debug.Log("enter");
    }

    void OnTriggerStay2D(Collider2D col)
    {
        TF.position = tra;
        //Debug.Log("stay");
        AtBG = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        tra = TF.position;
        Debug.Log("exit");
        AtBG = false;
    }
}
