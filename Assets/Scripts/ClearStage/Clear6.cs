using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear6 : MonoBehaviour
{
    bool clear;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        clear = GlobalVariables.clear6;
        WakeUp();
    }
    void WakeUp()
    {
        if (clear == true)
        {
            gameObject.SetActive(true);
            GlobalVariables.clear6 = clear;
        }
    }
}
