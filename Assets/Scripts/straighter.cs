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
        /*// xyz軸を軸にして1度、回転させているQuaternionを作成
        Quaternion move_q = Quaternion.Euler(0f, 0f, 1.0f);
        // 自身のQuaternionを取得
        Quaternion q = this.transform.rotation;
        // 合成して、自身に設定
        this.transform.rotation = q * move_q;*/
    }

    public void OnClick()
    {
        // x軸を軸にして毎秒2度、回転させるQuaternionを作成（変数をrotとする）
        Quaternion rot = Quaternion.AngleAxis(90, Vector3.forward);
        // 現在の自信の回転の情報を取得する。
        Quaternion q = this.transform.rotation;
        // 合成して、自身に設定
        this.transform.rotation = q * rot;
    }
}
