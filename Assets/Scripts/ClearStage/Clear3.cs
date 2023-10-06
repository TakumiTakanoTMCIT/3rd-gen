using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear3 : MonoBehaviour
{
    bool clear;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        clear = GlobalVariables.clear3;
        WakeUp();
    }
    void WakeUp()
    {
        if (clear == true)
        {
            gameObject.SetActive(true);
            GlobalVariables.clear3 = clear;
        }
    }
}
