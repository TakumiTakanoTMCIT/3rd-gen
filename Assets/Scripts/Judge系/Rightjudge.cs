using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rightjudge : MonoBehaviour
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
        //Debug.Log("Right" + isOn);
        //Debug.Log("Right " + ppcon.right);
        //Debug.Log(thiscol);

        if (isOn == true)
        {
            //Debug.Log("isOn==true");
            if (thiscol.gameObject.tag == "Wire")
            {
                Debug.Log("Wire");
                //Debug.Log("Right‚¾‚æ");
                ppcon.right = true;
            }
            else if(thiscol.gameObject.tag == null)
            {
                Debug.Log("null");
                ppcon.right = false;
            }
            else
            {
                Debug.Log("else");
                ppcon.right = false;
            }
        }
        /*else
        {
            //Debug.Log("isOn==false");
            ppcon.right = false;
        }*/
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("R isOn==true");
        thiscol = col;
        isOn = true;
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        //Debug.Log("R isOn==true");
        thiscol = col;
        isOn = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        //Debug.Log("R isOn==false");
        thiscol = col;
        isOn = false;
    }
}
