using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftJudge : MonoBehaviour
{
    public GameObject thisObject;
    PuzulPlayerCon ppcon;
    GameObject puzulp;
    Collider2D thiscol;
    bool game,onWire;
    // Start is called before the first frame update
    void Start()
    {
        game = false;
    }

    public void Prepare()
    {
        puzulp = GameObject.Find("PuzulPlayer");
        ppcon = puzulp.GetComponent<PuzulPlayerCon>();
        game = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(thiscol);

        if(game == true)
        {
            if (onWire == true)//基板上にいるかどうか確認
            {
                if (thiscol.gameObject.tag == "Wire" || thiscol.gameObject.tag == "Initial" || thiscol.gameObject.tag == "Finish")//WireTagに触れているなら動ける
                {
                    //Debug.Log("Wireに触れているので、左に動けます");
                    ppcon.left = true;
                }
                else//Wire以外にいるなら動けない
                {
                    //Debug.Log("Wireに触れていないので左には動けません");
                    ppcon.left = false;
                }
            }
            else//いなかったら無条件に移動不可
            {
                //Debug.Log("leftは何にも触れていない");
                ppcon.left = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        onWire = true;
        thiscol = col;
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        onWire = true;
        thiscol = col;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        onWire = false;
        thiscol = col;
    }
}
