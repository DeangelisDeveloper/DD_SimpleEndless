using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [Header("General")]
    [SerializeField] float speed = 0f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
