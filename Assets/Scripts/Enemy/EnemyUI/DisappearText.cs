using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Dissapear", 10.0f);//execute function after 10 sec
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Dissapear()
    {
        Destroy(this.gameObject);
    }
}
