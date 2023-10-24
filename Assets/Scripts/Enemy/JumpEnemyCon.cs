using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemyCon : MonoBehaviour
{
    public float jumpForce, timedelay;

    GameObject enemymanager;

    Transform TF;
    Vector3 pos;
    Rigidbody2D rb;
    Vector2 force;

    // Start is called before the first frame update
    void Start()
    {
        enemymanager = GameObject.Find("EnemyDeathUIManager");

        rb = GetComponent<Rigidbody2D>();
        TF = this.gameObject.transform;
        pos = TF.position;

        //MethodÇ0ïbå„Ç…åƒÇ—èoÇµÅAà»ç~ÇÕtimedelayñàÇ…é¿çs
        InvokeRepeating(nameof(Jump), 0f, timedelay);

        force = new Vector2(0f, jumpForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Jump()
    {
        force = new Vector2(0f, jumpForce);
        Debug.Log(force);
        rb.AddForce(force);
    }


    public void Death()
    {
        Destroy(this.gameObject);
        enemymanager.GetComponent<EnemyImage>().Imaging();
    }
}
