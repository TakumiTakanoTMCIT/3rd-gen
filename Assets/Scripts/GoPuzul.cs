using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoPuzul : MonoBehaviour
{
    public GameObject game;
    public Sprite OnSprite , OffSprite;

    bool isEnter;

    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = game.GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = OffSprite;

        isEnter = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClicked()//Playerが触れたらPuzulSceneに移動できます
    {
        if(isEnter == true)
        {
            SaveInf.instance.IntoPuzulScene();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            //Debug.Log("ぱずる起動！！！");
            spriteRenderer.sprite = OnSprite;

            isEnter = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            spriteRenderer.sprite = OffSprite;

            isEnter = false;
        }
    }
}
