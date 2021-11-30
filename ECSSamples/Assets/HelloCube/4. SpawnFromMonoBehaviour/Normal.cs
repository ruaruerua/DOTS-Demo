using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using Unity.Transforms;

public class Normal : MonoBehaviour
{
    public GameObject Prefab;
    public int CountX = 100;
    public int CountY = 100;
    // Start is called before the first frame update
    void Start()
    {

        for (var x = 0; x < CountX; x++)
        {
            for (var y = 0; y < CountY; y++)
            {
                // Efficiently instantiate a bunch of entities from the already converted entity prefab
                var gameObj = UnityEngine.Transform.Instantiate(Prefab);

                // Place the instantiated entity in a grid with some noise
                gameObj.transform.position = transform.TransformPoint(new float3(x * 1.3F, noise.cnoise(new float2(x, y) * 0.21F) * 2, y * 1.3F));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
