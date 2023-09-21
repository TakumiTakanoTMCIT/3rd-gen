using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upjudge : MonoBehaviour
{
    public GameObject thisObject;
    PuzulPlayerCon ppcon;
    GameObject puzulp;
    Collider2D thiscol;
    bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
    }

    public void Prepare()
    {
        puzulp = GameObject.Find("PuzulPlayer");
        ppcon = puzulp.GetComponent<PuzulPlayerCon>();
        isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == true)
        {
            //Debug.Log("isOn==true");
            if (thiscol.gameObject.tag == "Wire")
            {
                //Debug.Log("Left‚¾‚æ");
                ppcon.up = true;
            }
            else
            {
                ppcon.up = false;
            }
        }
        /*else if (isOn == false)
        {
            //Debug.Log("isOn==false");
            ppcon.up = false;
        }*/
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        thiscol = col;
        isOn = true;
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        thiscol = col;
        isOn = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        thiscol = col;
        isOn = false;
    }
}
