using TwitchIntegration;
using UnityEngine;

public class TwitchMover : TwitchMonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float MaxAddedForce = 100f;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    [TwitchCommand("move_object", "move", "m")]
    public void AddForce(float x, float y)
    {
        Vector2 force = new Vector2(x, y) * 10f;

        if (force.magnitude > MaxAddedForce)
        {
            force = force.normalized * MaxAddedForce;
        }

        rigidbody2d.AddForce(force, ForceMode2D.Impulse);
    }

    [TwitchCommand("heal", "h")]
    public void Heal()
    {
        Combat combat = GetComponent<Combat>();
        combat.Damage(-10);
    }
}