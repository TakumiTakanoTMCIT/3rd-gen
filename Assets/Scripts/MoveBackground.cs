using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this value to control the speed of movement

    private Vector3 lastMousePosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseDelta = Input.mousePosition - lastMousePosition;
        Vector3 moveDirection = new Vector3(mouseDelta.x, mouseDelta.y, 0);

        // Move the background image based on mouse movement
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        lastMousePosition = Input.mousePosition;

    }
}
