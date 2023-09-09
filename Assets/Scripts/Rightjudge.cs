using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rightjudge : MonoBehaviour
{
    public GameObject thisObject;
    PuzulPlayerCon ppcon;
    GameObject puzulp;
    Collider2D thiscol;
    bool isOn = false;
    // Start is called before the first frame update
    void Start()
    {
        puzulp = GameObject.Find("PuzulPlayer");
        ppcon = puzulp.GetComponent<PuzulPlayerCon>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(thiscol);
        if (isOn == true)
        {
            //Debug.Log("isOn==true");
            if (thiscol.gameObject.tag == "Wire")
            {
                Debug.Log("Left‚¾‚æ");
                ppcon.right = true;
            }
            else
            {
                ppcon.right = false;
            }
        }
        else if (isOn == false)
        {
            //Debug.Log("isOn==false");
            ppcon.right = false;
        }
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
