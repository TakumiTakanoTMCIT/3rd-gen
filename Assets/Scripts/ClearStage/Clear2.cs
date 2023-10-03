using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear2 : MonoBehaviour
{
    bool clear;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        clear = GlobalVariables.clear2;
        WakeUp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WakeUp()
    {
        if (clear == true)
        {
            gameObject.SetActive(true);

            GlobalVariables.clear2 = clear;
        }
    }
}
