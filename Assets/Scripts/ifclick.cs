using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifclick : MonoBehaviour
{
    public GameObject thisObject;
    public int num = 0;
    Renderer sren;
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        // Sprite�̏ꍇ��GetComponent<SpriteRenderer>
        sren = this.GetComponent<SpriteRenderer>();

        color = sren.material.color;

        color.r = 1.0f;  // RGB��R(��)�l
        color.g = 1.0f; // RGB��G(��)�l
        color.b = 1.0f; // RGB��B(��)�l
        color.a = 1.0f;// RGB�̃A���t�@�l(�����x�̒l)

        sren.material.color = color; // �ύX�����F���ɕύX

        thisObject.tag = "Substrate";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        if(num == 2)
        {
            num = 0;
        }else
        {
            num++;
        }

        Debug.Log(num);

        if(num== 0)
        {
            color.r = 1.0f;  // RGB��R(��)�l
            color.g = 1.0f; // RGB��G(��)�l
            color.b = 1.0f; // RGB��B(��)�l
            color.a = 1.0f;// RGB�̃A���t�@�l(�����x�̒l)
            thisObject.tag = "Substrate";
        }
        else if(num== 1)
        {
            color.r = 0f;  // RGB��R(��)�l
            color.g = 0f; // RGB��G(��)�l
            color.b = 0f; // RGB��B(��)�l
            color.a = 1.0f;// RGB�̃A���t�@�l(�����x�̒l)
            thisObject.tag = "Wire";
        }
        else if (num== 2)
        {
            color.r = 1.0f;  // RGB��R(��)�l
            color.g = 0.277f; // RGB��G(��)�l
            color.b = 1.0f; // RGB��B(��)�l
            color.a = 1.0f;// RGB�̃A���t�@�l(�����x�̒l)
            thisObject.tag = "Insulator";
        }

        sren.material.color = color; // �ύX�����F���ɕύX
    }
}
