using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float Force = 250f;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            AddForce(0, Force);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddForce(-Force, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AddForce(0, -Force);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            AddForce(Force, 0);
        }
    }

    public void AddForce(float x, float y)
    {
        Vector2 force = new Vector2(x, y);

        rigidbody2d.AddForce(force);
    }
}
