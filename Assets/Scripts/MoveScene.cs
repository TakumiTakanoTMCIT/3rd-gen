using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // コレ重要

public class MoveScene : MonoBehaviour
{
    private string Nscene , Pscene;

　　public static MoveScene instance;

    public GameObject clear1;

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
        /*if (Input.GetKeyDown(KeyCode.Tab))
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
        }*/
    }

    public void SaveNowScene()
    {
        Nscene = GlobalVariables.NowScene;
        

        Nscene = SceneManager.GetActiveScene().name;
        
        GlobalVariables.NowScene = Nscene;      //今のアクションシーンをグローバルに保存
    }

    public void SavePuzulScene()
    {
        Pscene = GlobalVariables.NowPuzulScene;


        Pscene = SceneManager.GetActiveScene().name;

        GlobalVariables.NowPuzulScene = Pscene;      //今のパズルシーンをグローバルに保存
    }

    public void CleardGame()
    {
        
        Nscene = GlobalVariables.NowScene;
        Debug.Log("NowScene :" + Nscene);
        if(GlobalVariables.NowScene == "Stage1")
        {
            clear1 = GameObject.Find("Clear1");
            GlobalVariables.clear1 = true;
            clear1.GetComponent<Clear1>().WakeUp();
        }
        else if(Nscene == "Stage2")
        {
            GlobalVariables.clear2 = true;
        }

        SceneManager.LoadScene("OpeningScene");
    }
}
