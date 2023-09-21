using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateManager : MonoBehaviour
{
    public float startpoint_X, startpoint_Y , endpoint_X , endpoint_Y;
    public Transform myCube;
    public GameObject startp, endp;
    GameObject bigin , finish;

    public int xCount , yCount;
    private int a, b;
    /*int r = 0;
    int i = 0;*/
    
    public void BiginGame()
    {
        Vector3 tmp = myCube.transform.position;

        for (a = 0; a < yCount; ++a)
        {
            for (b = 0; b < xCount; ++b)
            {
                //Debug.Log(a + "  " +b);
                Instantiate(myCube, tmp = new Vector3(startpoint_X + b, startpoint_Y + a, 0f), transform.rotation);

                //Debug.Log("b" + a + " " + b);
            }
            tmp.x = 0;
            //Debug.Log("a" + a + " " + b);
        }

        bigin = Instantiate(startp, tmp = new Vector3(startpoint_X + -1f, startpoint_Y, 0f), transform.rotation);
        bigin.name = "StartP";

        finish = Instantiate(endp, tmp = new Vector3( b + startpoint_X , a + startpoint_Y - 1f, 0f), transform.rotation);
        finish.name = "EndP";

        Debug.Log("lastpoint" + b + " " + a);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
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