using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WakeUp()
    {
        gameObject.SetActive(true);

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
