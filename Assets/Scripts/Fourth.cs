using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fourth : MonoBehaviour
{
    private Vector3 _moveDirection = new Vector3(0f, 0f, 1.05f);
    void Update()
    {
        transform.Rotate(0.1f, 0, 0);

        transform.Translate(0,0, 0.1f);

        transform.localScale *= 1.0001f;
    }
}
