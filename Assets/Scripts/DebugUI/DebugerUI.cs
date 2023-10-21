using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugerUI : MonoBehaviour
{
    PlayerCon pcon;
    bool Pjump;
    Rigidbody2D rb;
    Transform TF;

    public GameObject player;
    public TextMeshProUGUI veloy;//Textオブジェクト

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rb = player.GetComponent<Rigidbody2D>();
        TF = player.transform;
        pcon = player.GetComponent<PlayerCon>();
    }

    // Update is called once per frame
    void Update()
    {
        veloy.text = 
            "PlayerVeloY: " + rb.velocity.y 
            + "\n" + "PlayerVeloX: " + rb.velocity.x 
            + "\n" + "PlayerTransformY: " + TF.position.y 
            + "\n" + "PlayerTransformX: " + TF.position.x
            + "\n" + "isJumping: " + pcon.nowjump
            + "\n" + "What On FOOT: " + pcon.globalcol;
    }
}
