using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzulPlayerCon : MonoBehaviour
{
    public Transform thisObject;
    public bool up, down, right, left;

    Vector3 tbp , tmp;
    GameObject biginp;
    bool gamed = false;
    bool isclick = ifclick.onclick;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Initial), 2f);
    }

    void Initial()
    {
        biginp = GameObject.Find("StartP");
        //Debug.Log(biginp);

        //Vector3 tmp = thisObject.transform.position;
        //thisObject.transform.position = tmp;

        tbp = biginp.transform.position;
        tmp = thisObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Start pos" + tbp + "Player pos" + tmp);
        //Debug.Log("ppcon  " + right);
        if(Input.GetKeyDown(KeyCode.Tab))//　←Tabキーを押されたらパズルゲームが始まる
        {
            GameStarted();
        }

        if(gamed == true)
        {
            //Debug.Log("Game start");
            thisObject.transform.position = tmp;

            if (up == true)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    tmp.y += 1;
                }
            }
                        
            if(right == true)
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    tmp.x += 1;
                }
            }
            
            if(down == true)
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    tmp.y -= 1;
                }
            }
            
            if(left == true)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    tmp.x -= 1;
                }
            }
        }
    }

    public void GameStarted()
    {
        //tbp = thisObject.transform.position;
        tmp = tbp;
        gamed = true;
        //Debug.Log("Game was started");
        //Debug.Log(tbp);

        thisObject.transform.position = tmp;

        isclick = true;
        ifclick.onclick = isclick;
    }
}
