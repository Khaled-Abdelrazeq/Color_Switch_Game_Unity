using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private int rotationSpeed = 3;
    private Vector3 rotationAxis = new Vector3(0, 0, 1);

    void Update()
    {
        transform.Rotate(rotationAxis * Time.deltaTime * rotationSpeed);        
    }
}
