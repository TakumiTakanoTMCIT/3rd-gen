using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public PlayerCon con;

    public void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Down���Ȃɂ��ɐG�ꂽ");

        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("�G�ɐG��܂����B���S���܂�");
            con.Death();

            //������������
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
