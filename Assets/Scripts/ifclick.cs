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
        // Spriteの場合はGetComponent<SpriteRenderer>
        sren = this.GetComponent<SpriteRenderer>();

        color = sren.material.color;

        color.r = 1.0f;  // RGBのR(赤)値
        color.g = 1.0f; // RGBのG(緑)値
        color.b = 1.0f; // RGBのB(青)値
        color.a = 1.0f;// RGBのアルファ値(透明度の値)

        sren.material.color = color; // 変更した色情報に変更

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
            color.r = 1.0f;  // RGBのR(赤)値
            color.g = 1.0f; // RGBのG(緑)値
            color.b = 1.0f; // RGBのB(青)値
            color.a = 1.0f;// RGBのアルファ値(透明度の値)
            thisObject.tag = "Substrate";
        }
        else if(num== 1)
        {
            color.r = 0f;  // RGBのR(赤)値
            color.g = 0f; // RGBのG(緑)値
            color.b = 0f; // RGBのB(青)値
            color.a = 1.0f;// RGBのアルファ値(透明度の値)
            thisObject.tag = "Wire";
        }
        else if (num== 2)
        {
            color.r = 1.0f;  // RGBのR(赤)値
            color.g = 0.277f; // RGBのG(緑)値
            color.b = 1.0f; // RGBのB(青)値
            color.a = 1.0f;// RGBのアルファ値(透明度の値)
            thisObject.tag = "Insulator";
        }

        sren.material.color = color; // 変更した色情報に変更
    }
}
