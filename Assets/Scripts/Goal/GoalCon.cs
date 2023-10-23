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
        if(isGoal)
        {
            Invoke("ClearGame", 5.0f);//execute function after 5 sec :]
            while (10 > a)
            {
                //Debug.Log("Instantiate!!");
                playerObject = Instantiate(playerResource, new Vector3(0, 0, 0), Quaternion.identity);
                playerObject.transform.SetParent(parenter.transform, false);
                Vector3 pos = playerObject.transform.position;
                pos.y = (a * 20f) + 100f;
                pos.x = 1000f;
                playerObject.transform.position = pos;
                a++;
            }
        }
    }

    void ClearGame()
    {
        MoveScene.instance.CleardGame();
    }
}
