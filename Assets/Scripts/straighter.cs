using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class straighter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        /*// xyz�������ɂ���1�x�A��]�����Ă���Quaternion���쐬
        Quaternion move_q = Quaternion.Euler(0f, 0f, 1.0f);
        // ���g��Quaternion���擾
        Quaternion q = this.transform.rotation;
        // �������āA���g�ɐݒ�
        this.transform.rotation = q * move_q;*/
    }

    public void OnClick()
    {
        // x�������ɂ��Ė��b2�x�A��]������Quaternion���쐬�i�ϐ���rot�Ƃ���j
        Quaternion rot = Quaternion.AngleAxis(90, Vector3.forward);
        // ���݂̎��M�̉�]�̏����擾����B
        Quaternion q = this.transform.rotation;
        // �������āA���g�ɐݒ�
        this.transform.rotation = q * rot;
    }
}
