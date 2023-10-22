using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalCon : MonoBehaviour
{
    public float scaleX, scaleY, maxY,positionX;//Position of Image

    public GameObject parenter;//CanvasObject

    public Sprite comment;//BaseSprite

    Vector2 scale, pos;

    GameObject obj;
    RectTransform rect;
    Image imager;

    float time = 0.2f;

    public float count = 0;

    bool isGoal = false;

    public float movingSpeed = 0f;

    public GameObject playerResource; // コピー元
    private GameObject playerObject; // コピー先

    int a = 0;

    public void Goal()
    {
        isGoal = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(10f > count);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (isGoal)
        {
            if(11 > count)
            {
                Debug.Log(obj);
                Debug.Log(obj.transform.position);
                Debug.Log(count);
                if (10f > count)
                {
                    Debug.Log("djfal;k;dfjkas;ls");
                    time -= Time.deltaTime;
                    if (time <= 0.5f)
                    {
                        count++;

                        time = 0.2f;

                        obj = new GameObject();
                        obj.name = "lastcomment";
                        rect = obj.AddComponent<RectTransform>() as RectTransform;
                        imager = obj.AddComponent<Image>() as Image;
                        obj.transform.SetParent(parenter.transform, false);//make Image gameObject
                        imager.sprite = comment;//apply comment to image

                        pos = obj.transform.position;
                        //pos.y = Random.Range(0f, 550f);
                        pos.y = Random.Range(25f, 430f);//430max,25smallest

                        pos.x = positionX;//wanna generate comment from edge of screen :]

                        obj.transform.position = pos;//change position.y random

                        scale = rect.localScale;
                        scale.x = scaleX;
                        scale.y = scaleY;
                        rect.localScale = scale;

                        pos.x -= movingSpeed * Time.deltaTime;
                        obj.transform.position = pos;
                    }
                }
            }
        }*/
        while(10 > a)
        {
            Debug.Log("Instantiate!!");
            playerObject = Instantiate(playerResource, new Vector3(0, 0, 0), Quaternion.identity);
            playerObject.transform.SetParent(parenter.transform, false);
            Vector3 pos = playerObject.transform.position;
            pos.y = (a * 20f) + 100f;
            pos.x = 1000f;
            playerObject.transform.position = pos;
            a++;
        }

        /*Vector3 position = playerObject.transform.position;
        position.x += 0.05;

        playerObject.transform.position = position;*/

    }
}
