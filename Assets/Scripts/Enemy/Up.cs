using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    public PlayerCon con;
    public EnemyCon Econ;
    
    public void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("UP���Ȃɂ��ɐG�ꂽ");

        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player�ɓ��܂�܂������S���܂�");
            Econ.Death();
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}