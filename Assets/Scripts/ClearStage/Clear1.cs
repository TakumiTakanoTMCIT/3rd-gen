using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear1 : MonoBehaviour
{
    bool clear;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        clear = GlobalVariables.clear1;
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
            GlobalVariables.clear1 = clear;
        }

        /*bool clear = GlobalVariables.clear1;
        bool alclear = GlobalVariables.alreadyclear1;

        if (clear == true || alclear == true)
        {
            gameObject.SetActive(true);
            alclear = true;

        }

        GlobalVariables.alreadyclear1 = alclear;*/
    }
}
