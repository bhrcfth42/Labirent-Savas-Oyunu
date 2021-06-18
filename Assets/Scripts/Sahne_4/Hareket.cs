using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    float inputX, inputY;
    Vector3 stickDirection;
    Camera mainCam;
    [Range(1, 20)]
    public float rotationSpeed;
    void Start()
    {
        mainCam = Camera.main;
    }
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        stickDirection = new Vector3(inputX, 0f, inputY);
        InputMove();
        InputRotation();

    }
    private void InputMove()
    {
        transform.Translate(stickDirection * Time.deltaTime * rotationSpeed);
    }
    private void InputRotation()
    {
        Vector3 rotOfset = mainCam.transform.TransformDirection(stickDirection);
        rotOfset.y = 0f;

        transform.forward = Vector3.Slerp(transform.forward, rotOfset, Time.deltaTime * rotationSpeed);
    }
}
