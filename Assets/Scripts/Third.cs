using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Third : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _scale = new Vector3(1,1,1);

    private void Update()
    {
        gameObject.transform.localScale += 0.0001f * _scale * _speed;
    }
}