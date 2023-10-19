using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ?R???d?v

public class MoveScene : MonoBehaviour
{
    private string Nscene , Pscene;

    public static MoveScene instance;

    //public GameObject clear1;

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
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log(scene.name + " scene loaded");
    }

    public void SaveNowScene()
    {
        GlobalVariables.NowScene = SceneManager.GetActiveScene().name;      //?????A?N?V?????V?[?????O???[?o????????

        Nscene = GlobalVariables.NowScene;

        Debug.Log("???V?[?????O???[?o?????Z?[?u?????A?????V?[???????O???F" +Nscene+"??Nscene  " + GlobalVariables.NowScene + "???O???[?o??????????");
    }

    public void SavePuzulScene()
    {
        GlobalVariables.NowPuzulScene = SceneManager.GetActiveScene().name;      //?????p?Y???V?[?????O???[?o????????
    }

    public void CleardGame()
    {
        
        Nscene = GlobalVariables.NowScene;

        Debug.Log("NowScene :" + Nscene);
        if(Nscene == "Stage1")
        {
            //clear1 = GameObject.Find("Clear1");
            GlobalVariables.clear1 = true;

            SceneManager.LoadScene("OpeningScene");
        }
        else if(Nscene == "Stage2")
        {
            GlobalVariables.clear2 = true;

            SceneManager.LoadScene("OpeningScene");
        }
        else if(Nscene == "Stage3")
        {
            GlobalVariables.clear3 = true;

            SceneManager.LoadScene("OpeningScene");
        }
        else if(Nscene == "Stage4")
        {
            GlobalVariables.clear4 = true;

            SceneManager.LoadScene("OpeningScene");
        }
        else if(Nscene == "Stage5")
        {
            GlobalVariables.clear5 = true;

            SceneManager.LoadScene("OpeningScene");
        }
        else if(Nscene == "Stage6")
        {
            GlobalVariables.clear6 = true;

            SceneManager.LoadScene("OpeningScene");
        }
        else if(Nscene == "Stage7")
        {
            GlobalVariables.clear7 = true;

            SceneManager.LoadScene("OpeningScene");
        }
        else if(Nscene == "Stage8")
        {
            GlobalVariables.clear8 = true;

            SceneManager.LoadScene("OpeningScene");
        }
        else if(Nscene == "Stage9")
        {
            GlobalVariables.clear9 = true;

            SceneManager.LoadScene("OpeningScene");
        }
        else if(Nscene == "Stage10")
        {
            GlobalVariables.clear10 = true;

            SceneManager.LoadScene("OpeningScene");
        }
    }
}
