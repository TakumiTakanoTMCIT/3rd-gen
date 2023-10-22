using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon : MonoBehaviour
{
    Transform myTransform;

    public float speed = 1.0f;
    public float powerX = 1.0f;

    public EnemyImage enemyImage;

    GameObject enemymanager;

    // Start is called before the first frame update
    void Start()
    {
        // transformを取得
        myTransform = this.transform;

        enemymanager = GameObject.Find("EnemyDeathUIManager");
    }

    // Update is called once per frame
    void Update()
    {
        // ワールド座標を基準に、座標を取得
        Vector3 worldPos = myTransform.position;

        worldPos.x += speed*powerX*Time.deltaTime;    // ワールド座標を基準にした、x座標を1に変更

        myTransform.position = worldPos;  // ワールド座標での座標を設定
    }

    public void OnRight()
    {
        powerX = -1.0f;
    }

    public void OnLeft()
    {
        powerX = 1.0f;
    }

    public void Death()
    {
        Destroy(this.gameObject);
        enemymanager.GetComponent<EnemyImage>().Imaging();
    }
}