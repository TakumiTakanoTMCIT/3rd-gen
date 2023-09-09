using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadplayscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene("PlayScene");*/      //  ©‰º‚Ì‚â‚è•û‚É‚¿‚å‚Á‚Æ•Ï‚¦‚Ä‚İ‚Ü‚µ‚½iŠ¾j
    }

    public void BotanPush()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
