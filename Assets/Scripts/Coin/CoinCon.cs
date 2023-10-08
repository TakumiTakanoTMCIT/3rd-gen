using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Touch()
    {
        GlobalVariables.Coins += 1;

        Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("コイン取った！！");

            GlobalVariables.Coins += 1;

            Destroy(this.gameObject);
        }
    }
}
