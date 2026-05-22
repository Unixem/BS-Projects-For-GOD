using UnityEngine;

public class RotateCubesNStuff : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
