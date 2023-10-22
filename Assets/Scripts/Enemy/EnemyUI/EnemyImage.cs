using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyImage : MonoBehaviour
{
    public GameObject canvas;//キャンバス
    public GameObject Image;
    //public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 enemypos = enemy.transform.position;

        

        /*GameObject prefab = (GameObject)Instantiate(text);
        prefab.transform.SetParent(canvas.transform, false);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Imaging()
    {
        //Debug.Log("Imagingが発動！！");
        Vector3 playerpos = GameObject.Find("Player").transform.position;

        playerpos.y += -2;

        GameObject cloneObject = Instantiate(Image, playerpos, Quaternion.identity);
        cloneObject.transform.parent = canvas.transform;
    }
}
