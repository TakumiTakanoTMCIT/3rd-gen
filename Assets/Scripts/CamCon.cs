using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCon : MonoBehaviour
{
    /*float playerX;
    Vector3 Playertmp;
    GameObject Cam;
    GameObject Player;
    */

    private void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

        /*Cam = GameObject.Find("Camera");
        Player = GameObject.Find("Player");

        Playertmp = Player.transform.position;
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*Playertmp = Player.transform.position;

        playerX = Playertmp.x;

        //Debug.Log("playerX" + playerX);
        //Debug.Log("Cam.transform" +  Cam.transform.position);

        if(playerX > 0 && playerX <19)
        {
            Cam.transform.position = new Vector3(playerX, 0, -10);
        }

        //new Vector2(Playertmp.x, Playertmp.y);*/
    }
}
