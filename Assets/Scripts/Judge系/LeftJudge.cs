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
            if (onWire == true)//Šî”Âã‚É‚¢‚é‚©‚Ç‚¤‚©Šm”F
            {
                if (thiscol.gameObject.tag == "Wire" || thiscol.gameObject.tag == "Initial" || thiscol.gameObject.tag == "Finish")//WireTag‚ÉG‚ê‚Ä‚¢‚é‚È‚ç“®‚¯‚é
                {
                    //Debug.Log("Wire‚ÉG‚ê‚Ä‚¢‚é‚Ì‚ÅA¶‚É“®‚¯‚Ü‚·");
                    ppcon.left = true;
                }
                else//WireˆÈŠO‚É‚¢‚é‚È‚ç“®‚¯‚È‚¢
                {
                    //Debug.Log("Wire‚ÉG‚ê‚Ä‚¢‚È‚¢‚Ì‚Å¶‚É‚Í“®‚¯‚Ü‚¹‚ñ");
                    ppcon.left = false;
                }
            }
            else//‚¢‚È‚©‚Á‚½‚ç–³ğŒ‚ÉˆÚ“®•s‰Â
            {
                //Debug.Log("left‚Í‰½‚É‚àG‚ê‚Ä‚¢‚È‚¢");
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
