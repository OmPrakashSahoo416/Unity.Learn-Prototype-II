using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnBoundary : MonoBehaviour
{
    private float boundaryTopEnd = 40f;
    private float boundaruLowEnd = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > boundaryTopEnd) {

            Destroy(gameObject);
        
        }
        if (transform.position.z < boundaruLowEnd) {

            Destroy(gameObject);
        }
    }
}
