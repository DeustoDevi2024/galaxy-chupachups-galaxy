using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalRotation : MonoBehaviour
{
    // Start is called before the first frame update

    public float speedRotation = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(speedRotation* Time.deltaTime * 7, speedRotation* Time.deltaTime * 7, 0f);
    }
}
