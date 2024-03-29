using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSaber : MonoBehaviour
{
    public LayerMask layer;
    Vector3 PrePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - PrePos, hit.transform.up) > 130) ;
            {
                Destroy(hit.transform.gameObject);
            }
        }
        PrePos = transform.position;
    }
}
