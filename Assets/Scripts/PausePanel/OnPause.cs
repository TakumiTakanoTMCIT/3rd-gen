using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnPause : MonoBehaviour
{
    public GameObject Panel;



    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Tab))
        {
            Topause();
        }
    }

    void Topause()
    {
        Panel.SetActive(true);
        Time.timeScale = 0;
    }
}
