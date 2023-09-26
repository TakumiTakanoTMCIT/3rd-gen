using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Downjudge : MonoBehaviour
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
        if(game==true)
        {
            if (onWire == true)//Šî”Âã‚É‚¢‚é‚©‚Ç‚¤‚©Šm”F
            {
                if (thiscol.gameObject.tag == "Wire")//WireTag‚ÉG‚ê‚Ä‚¢‚é‚È‚ç“®‚¯‚é
                {
                    Debug.Log("Wire‚ÉG‚ê‚Ä‚¢‚é‚Ì‚ÅA‰º‚É“®‚¯‚Ü‚·");
                    ppcon.down = true;
                }
                else//WireˆÈŠO‚É‚¢‚é‚È‚ç“®‚¯‚È‚¢
                {
                    Debug.Log("Wire‚ÉG‚ê‚Ä‚¢‚È‚¢‚Ì‚Å‰º‚É‚Í“®‚¯‚Ü‚¹‚ñ");
                    ppcon.down = false;
                }
            }
            else//‚¢‚È‚©‚Á‚½‚ç–³ğŒ‚ÉˆÚ“®•s‰Â
            {
                Debug.Log("down‚Í‰½‚É‚àG‚ê‚Ä‚¢‚È‚¢");
                ppcon.down = false;
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
