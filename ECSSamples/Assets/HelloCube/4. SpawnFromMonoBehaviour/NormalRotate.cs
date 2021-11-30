using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using Unity.Transforms;

public class NormalRotate : MonoBehaviour
{
    public int rotateSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;
        transform.rotation = math.mul(math.normalize(transform.rotation),quaternion.AxisAngle(math.up(), rotateSpeed * deltaTime));
    }
}
