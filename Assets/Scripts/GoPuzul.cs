using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoPuzul : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClicked()//Playerが触れたらPuzulSceneに移動できます
    {
        SaveInf.instance.IntoPuzulScene();
    }
}
