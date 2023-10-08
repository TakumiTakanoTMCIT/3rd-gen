using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon : MonoBehaviour
{
    Transform myTransform;

    public float speed = 1.0f;
    public float powerX = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        // transform���擾
        myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // ���[���h���W����ɁA���W���擾
        Vector3 worldPos = myTransform.position;

        worldPos.x += speed*powerX;    // ���[���h���W����ɂ����Ax���W��1�ɕύX

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
    }
}