using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzulPlayerCon : MonoBehaviour
{
    public Transform thisObject;
    public bool up, down, right, left;

    Vector3 tbp , tmp;
    GameObject biginp;
    public static bool gamed = false;
    //bool isclick = ifclick.onclick;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke(nameof(Initial), 2f);
    }

    public void Initial()
    {
        biginp = GameObject.Find("StartP");
        thisObject.transform.position = biginp.transform.position;
        //Debug.Log(biginp);

        //Vector3 tmp = thisObject.transform.position;
        //thisObject.transform.position = tmp;
        //Debug.Log(tbp);
        gamed = true;
        Debug.Log("gamed!!!!!!!!!!!!!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        tmp = thisObject.transform.position;
        Debug.Log("Playerの座標" + thisObject.transform.position);
        Debug.Log("tmpの座標" + tmp);
        //Debug.Log(gamed);
        //Debug.Log("Start pos" + tbp + "Player pos" + tmp);
        //Debug.Log("ppcon  " + right);
        if (Input.GetKeyDown(KeyCode.Tab))//　←Tabキーを押されたらパズルゲームが始まる
        {
            GameStarted();
        }

        if(gamed == true)
        {
            //Debug.Log(tmp + " " + thisObject.transform.position);
            //Debug.Log("Playing Now");

            if (up == true)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    tmp.y += 1;
                }
            }
                        
            if(right == true)
            {
                //Debug.Log("right==true");
                if (Input.GetKeyDown(KeyCode.D))
                {
                    //Debug.Log("Pushed the D button");
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

            thisObject.transform.position = tmp;
        }
    }

    public void GameStarted()
    {
        //tbp = thisObject.transform.position;
        tmp = tbp;
        //gamed = true;
        //Debug.Log("Game was started");
        //Debug.Log(tbp);

        thisObject.transform.position = tmp;

        //isclick = true;
        //ifclick.onclick = isclick;
    }
}
