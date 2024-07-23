using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    private void Update()
    {
/*        var nextPosition = transform.position;
        nextPosition.z += 0.01f;
        transform.position = nextPosition;*/


        transform.Translate(0, 0, 0.1f);
    }
}
