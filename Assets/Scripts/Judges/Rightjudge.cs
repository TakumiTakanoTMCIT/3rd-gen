using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rightjudge : MonoBehaviour
{
    public GameObject thisObject;
    PuzulPlayerCon ppcon;
    GameObject puzulp;
    Collider2D thiscol;
    bool game , onWire;
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
            if(onWire == true)//���ɂ��邩�ǂ����m�F
            {
                if (thiscol.gameObject.tag == "Wire" || thiscol.gameObject.tag == "Initial" || thiscol.gameObject.tag == "Finish")//WireTag�ɐG��Ă���Ȃ瓮����
                {
                    //Debug.Log("Wire�ɐG��Ă���̂ŁA�E�ɓ����܂�");
                    ppcon.right = true;
                }
                else//Wire�ȊO�ɂ���Ȃ瓮���Ȃ�
                {
                    //Debug.Log("Wire�ɐG��Ă��Ȃ��̂ŉE�ɂ͓����܂���");
                    ppcon.right = false;
                }
            }
            else//���Ȃ������疳�����Ɉړ��s��
            {
                //Debug.Log("right���ɂ��G��Ă��Ȃ�");
                ppcon.right = false;
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