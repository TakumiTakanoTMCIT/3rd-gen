using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalNum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class GlobalVariables
{
    public static Vector3 PlayertransformpositionV3;//GlobalVariableで新しいクラスを作るとどんなときでもこの変数を使うことができるみたいです
    public static string NowScene;
    public static string NowPuzulScene;
    public static bool clear1 , clear2;
    public static bool alreadyclear1,alreadyclear2;
}