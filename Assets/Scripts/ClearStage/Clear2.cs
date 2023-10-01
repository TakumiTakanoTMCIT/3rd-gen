using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear2 : MonoBehaviour
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
        bool clear = GlobalVariables.clear2;
        bool alclear = GlobalVariables.alreadyclear2;

        if (clear == true || alclear == true)
        {
            gameObject.SetActive(true);
            alclear = true;

        }

        GlobalVariables.alreadyclear2 = alclear;
    }
}
