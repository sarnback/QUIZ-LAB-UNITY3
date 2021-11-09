using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBackground : MonoBehaviour
{
    public float rotateSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        //Sätter rotateSpeed 1 på Z-axeln(0 på X och 0 på Y axeln) runt världen runt den(Space.World)
        this.transform.Rotate(0, 0, rotateSpeed, Space.World);

    }
}
