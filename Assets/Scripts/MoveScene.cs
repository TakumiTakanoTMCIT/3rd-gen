using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // コレ重要

public class MoveScene : MonoBehaviour
{
    private string nowscene;

　　public static MoveScene instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            nowscene = SceneManager.GetActiveScene().name;//今のシーンの名前を保存
            
            SaveInf.instance.IntoPuzulScene();

            if ( nowscene == "SampleScene")
            {
                SceneManager.LoadScene("PuzulScene");
                SaveInf.instance.IntoPuzulScene();
            }
            else if( nowscene == "PuzulScene" )
            {
                SceneManager.LoadScene("SampleScene");
                SaveInf.instance.IntoActionScene();
            }
            nowscene = GlobalVariables.CurrentScene;
            GlobalVariables.CurrentScene = nowscene;
        }
    }

    void SaveName()
    {
        nowscene = SceneManager.GetActiveScene().name;//今のシーンをここのnowsceneに保存
        GlobalVariables.CurrentScene = nowscene;      //nowsceneをグローバルに保存
    }

    void UseName()
    {
        nowscene = GlobalVariables.CurrentScene;      //今のシーンにグローバル変数を代入
    }
}
