using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCon : MonoBehaviour
{
    public float speed = 1.0f;
    public float powerX = 1.0f;

    public EnemyImage enemyImage;

    GameObject enemymanager;

    SpriteRenderer sp;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        enemymanager = GameObject.Find("EnemyDeathUIManager");

        sp = this.GetComponent<SpriteRenderer>();
        sp.flipX = false;
    }

    // Update is called once per frame
    void Update()
    {
        // ���[���h���W����ɁA���W���擾
        Vector3 worldPos = this.transform.position;

        worldPos.x += speed*powerX*Time.deltaTime;    // ���[���h���W����ɂ����Ax���W��1�ɕύX

        this.transform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�
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