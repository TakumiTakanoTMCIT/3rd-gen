using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �R���d�v

public class MoveScene : MonoBehaviour
{
    private string Nscene , Pscene;

�@�@public static MoveScene instance;

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
            nowscene = SceneManager.GetActiveScene().name;//���̃V�[���̖��O��ۑ�
            
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
        
        GlobalVariables.NowScene = Nscene;      //���̃A�N�V�����V�[�����O���[�o���ɕۑ�
    }

    public void SavePuzulScene()
    {
        Pscene = GlobalVariables.NowPuzulScene;


        Pscene = SceneManager.GetActiveScene().name;

        GlobalVariables.NowPuzulScene = Pscene;      //���̃p�Y���V�[�����O���[�o���ɕۑ�
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
