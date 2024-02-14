using TwitchIntegration;
using UnityEngine;

public class PlayerMover : TwitchMonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float MaxAddedForce = 10f;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    [TwitchCommand("move_object", "move", "m")]
    public void AddForce(float x, float y)
    {
        Vector2 force = new Vector2(x, y) * 100f;

        if (force.magnitude > MaxAddedForce)
        {
            force = force.normalized * MaxAddedForce;
        }

        rigidbody2d.AddForce(force);
    }
}
