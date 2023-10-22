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
        // transform���擾
        myTransform = this.transform;

        enemymanager = GameObject.Find("EnemyDeathUIManager");
    }

    // Update is called once per frame
    void Update()
    {
        // ���[���h���W����ɁA���W���擾
        Vector3 worldPos = myTransform.position;

        worldPos.x += speed*powerX*Time.deltaTime;    // ���[���h���W����ɂ����Ax���W��1�ɕύX

        myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�
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