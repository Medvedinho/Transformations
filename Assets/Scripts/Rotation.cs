using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _directionRotation;
    private void Update()
    {
        transform.Rotate(_directionRotation);
    }
}
