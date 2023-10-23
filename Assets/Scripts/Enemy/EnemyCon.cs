using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCon : MonoBehaviour
{
    public float speed = 1.0f;
    public float powerX = 1.0f;

    [SerializeField]
    float gravityScale;

    public EnemyImage enemyImage;

    GameObject enemymanager;

    SpriteRenderer sp;
    Rigidbody2D rb;

    Vector3 gravity;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gravityScale);
        rb = this.GetComponent<Rigidbody2D>();
        enemymanager = GameObject.Find("EnemyDeathUIManager");

        sp = this.GetComponent<SpriteRenderer>();
        sp.flipX = false;
    }

    // Update is called once per frame
    void Update()
    {
        // ワールド座標を基準に、座標を取得
        Vector3 worldPos = this.transform.position;

        //worldPos.x += speed*powerX*Time.deltaTime;    // ワールド座標を基準にした、x座標を1に変更

        gravity = new Vector3(gravityScale, 0f, 0f);
        rb.AddForce(gravity);
        Debug.Log(gravity + " " + gravityScale + this.gameObject.name);

        //this.transform.position = worldPos;  // ワールド座標での座標を設定
    }

    public void OnRight()
    {
        powerX = -1.0f;
        sp.flipX = false;
    }

    public void OnLeft()
    {
        powerX = 1.0f;
        sp.flipX = true;
    }

    public void Death()
    {
        Destroy(this.gameObject);
        enemymanager.GetComponent<EnemyImage>().Imaging();
    }
}