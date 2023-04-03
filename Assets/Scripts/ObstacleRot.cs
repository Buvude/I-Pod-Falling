using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRot : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    int rand;
    private void Start()
    {
        rand = Random.Range(0, 2);
        
    }
    private void Update()
    {
        if (rand == 0)
        {
            transform.Rotate(transform.forward * -rotationSpeed);
        } else transform.Rotate(transform.forward * rotationSpeed);

    }
}
