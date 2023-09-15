using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveInfo : MonoBehaviour
{
    GameObject Player;
    Transform TF;
    //Vector3 saveTF;
    Vector3 globalpos;
    //Vector3 tbp;
    // Start is called before the first frame update

    public static SaveInfo instance;

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

    void Start()
    {
        globalpos = GlobalVariables.PlayertransformpositionV3;

        Player = GameObject.Find("Player");
        TF = Player.transform;

        Debug.Log("GlobalPos: " + globalpos);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("TF.position:" + TF.position);
        //Debug.Log("GlobalPos: " + globalpos);
    }

    public void IntoPuzulScene()//SampleSceneでPuzulPlayerConでTabを押すとこの関数が動きます
    {
        Debug.Log("movepuzulscene");

        //Debug.Log(TF.position);

        //saveTF = TF.position;

        globalpos = TF.position;

        SceneManager.LoadScene("PuzulScene");
    }

    public void IntoActionScene()//PuzulSceneでMoveActionSceneスクリプトでSpaceを押されると、この関数が呼び出されます
    {
        Debug.Log("moveactionscene");

        SceneManager.LoadScene("SampleScene");

        Invoke(nameof(FindPlayer), 0.1f);
    }

    public void FindPlayer()
    {
        Debug.Log("Atsamplescene");
        //TF.position = saveTF;
        Player = GameObject.Find("Player");
        TF = Player.transform;

        TF.position = globalpos;
    }
}