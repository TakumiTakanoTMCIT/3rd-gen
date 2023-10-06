using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear10 : MonoBehaviour
{
    bool clear;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        clear = GlobalVariables.clear10;
        WakeUp();
    }
    void WakeUp()
    {
        if (clear == true)
        {
            gameObject.SetActive(true);
            GlobalVariables.clear10 = clear;
        }
    }
}
