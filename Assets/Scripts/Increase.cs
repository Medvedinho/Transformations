using UnityEngine;

public class Increase : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _scale = new Vector3(1,1,1);

    private void Update()
    {
        transform.localScale += _scale * _speed * Time.deltaTime;
    }
}