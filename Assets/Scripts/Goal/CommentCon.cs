using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentCon : MonoBehaviour
{
    Vector3 pos;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
        speed = Random.Range(-2.5f, -0.9f);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(pos);
        pos.x += speed;
        this.transform.position = pos;
    }
}
