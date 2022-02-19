using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool isTouching;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float controlSpeed;
    private float TouchPosX;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        GetInput();
        MoveForward();
        SlideCharacter();
    }

    private void GetInput()
    {
        if (Input.GetMouseButton(0))
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }

    private void MoveForward()
    {
        transform.position += Vector3.forward * movementSpeed * Time.deltaTime;
    }

    private void SlideCharacter()
    {
        if (isTouching)
        {
            TouchPosX += Input.GetAxis("Mouse X") * controlSpeed * Time.deltaTime;
        }

        transform.position = new Vector3(TouchPosX, transform.position.y, transform.position.z);
    }
}
