using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateManager : MonoBehaviour
{
    public Transform myCube;
    public GameObject startp, endp;
    GameObject bigin , finish;

    public int xCount , yCount;
    private int a, b;
    /*int r = 0;
    int i = 0;*/
    // Start is called before the first frame update
    void Start()
    {
        Vector3 tmp = myCube.transform.position;

        for (a = 0; a < yCount; ++a)
        {
            for (b = 0; b < xCount; ++b)
            {
                //Debug.Log(a + "  " +b);
                Instantiate(myCube, tmp = new Vector3(0f + b, 4.5f + a, 0f), transform.rotation);

                //Debug.Log("b" + a + " " + b);
            }
            tmp.x = 0;
            //Debug.Log("a" + a + " " + b);
        }

        bigin = Instantiate(startp, tmp = new Vector3(-1f,4.5f,0f),transform.rotation);
        bigin.name = "OhMyGod";

        finish = Instantiate(endp, tmp = new Vector3(0f + b, 3.5f + a, 0f), transform.rotation);
        finish.name = "Mickey";
    }

    void Update()
    {
        //Vector3 tmp = myCube.transform.position;
        //myCube.transform.position = new Vector3(tmp.x + 100, tmp.y, tmp.z);

        /*if(r < xCount)
        {
            if (i < xCount)
            {
                Instantiate(myCube, tmp = new Vector3(tmp.x + r, tmp.y + i, tmp.z), transform.rotation);

                Debug.Log(i);
                i++;
            }

            Debug.Log(r);
            r++;
        }*/
    }
}