using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBackground : MonoBehaviour
{
    public float rotateSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        //S�tter rotateSpeed 1 p� Z-axeln(0 p� X och 0 p� Y axeln) runt v�rlden runt den(Space.World)
        this.transform.Rotate(0, 0, rotateSpeed, Space.World);

    }
}
