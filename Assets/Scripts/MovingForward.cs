using UnityEngine;

public class MovingForward : MonoBehaviour
{
    [SerializeField] private Vector3 _moveDirection = new Vector3 (0f, 0f, 0f);
    private void Update()
    {
        transform.Translate(_moveDirection);
    }
}
