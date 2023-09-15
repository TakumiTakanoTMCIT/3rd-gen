using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judgement : MonoBehaviour
{
    public GameObject thisObject;
    PuzulPlayerCon ppcon;
    GameObject puzulp;
    // Start is called before the first frame update
    void Start()
    {
        puzulp = GameObject.Find("PuzulPlayer");
        ppcon = puzulp.GetComponent<PuzulPlayerCon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject + this.gameObject.name);

        if (thisObject.name == "Up")
        {
            //Debug.Log("Up‚¾‚æ");
            ppcon.up=true;
            //Debug.Log("UpisEnter");
        }
        else
        {
            ppcon.up=false;
        }
        
        if(thisObject.name == "Down")
        {
            //Debug.Log("Down‚¾‚æ");
            ppcon.down=true;
            //Debug.Log("DownisEnter");
        }
        else
        {
            ppcon.down=false;
        }
        
        
        if(thisObject.name == "Right")
        {
            //Debug.Log("Right‚¾‚æ");
            ppcon.right = true;
            //Debug.Log("RightisEnter");
        }
        else
        {
            ppcon.right=false;
        }

        if(thisObject.name == "Left")
        {
            //Debug.Log("Left‚¾‚æ");
            ppcon.left = true;
            //Debug.Log("LeftisEnter");
        }
        else
        {
            ppcon.left=false;
        }
    }
}
