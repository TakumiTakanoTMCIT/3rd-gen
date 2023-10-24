using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpEnemyCon : MonoBehaviour
{
    public float jumpForce, timedelay;

    Transform TF;
    Vector3 pos;
    Rigidbody2D rb;
    Vector2 force;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        TF = this.gameObject.transform;
        pos = TF.position;

        //MethodÇ0ïbå„Ç…åƒÇ—èoÇµÅAà»ç~ÇÕtimedelayñàÇ…é¿çs
        InvokeRepeating(nameof(Jump), 0f, timedelay);

        force = new Vector2(0f, jumpForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Jump()
    {
        rb.AddForce(force);
    }
}
