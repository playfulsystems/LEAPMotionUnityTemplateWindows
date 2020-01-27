using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnSpace : MonoBehaviour
{
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            transform.position = startPos;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
