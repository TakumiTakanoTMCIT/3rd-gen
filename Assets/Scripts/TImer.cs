using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TImer : MonoBehaviour
{
    public TextMeshProUGUI time;//Textオブジェクト

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "Time: " + Mathf.Floor(Time.time);
    }
}
