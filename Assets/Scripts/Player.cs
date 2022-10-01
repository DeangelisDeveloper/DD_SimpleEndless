using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("General")]
    [SerializeField] Rigidbody2D rb = null;
    [SerializeField] float speed = 0f;

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float moveY = Input.GetAxisRaw("Vertical");
        float vel = moveY * speed;
        rb.velocity = Vector2.up * vel * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Collision")
            Manager.instance.GameEnd();
    }
}
