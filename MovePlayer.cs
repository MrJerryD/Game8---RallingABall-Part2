using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float speed = 10f;

    public Vector3 spawnPosition = new Vector3(0, 0, 0);

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rigidbody.AddForce(new Vector3(horizontal * speed, rigidbody.velocity.y, vertical * speed));


        if (gameObject.transform.position.y <= -10)
        {
            transform.position = spawnPosition;
        }
    }
}
