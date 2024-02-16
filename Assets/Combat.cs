using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Combat : MonoBehaviour
{
    public int hp = 100;
    public TMP_Text hpText;
    public Rigidbody2D rigidbody2d;

    public float previousSpeed;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        Damage(0);
    }

    private void Update()
    {
        previousSpeed = rigidbody2d.velocity.magnitude;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out Combat combat))
        {
            float speedDifference = previousSpeed - combat.previousSpeed;

            Debug.Log(speedDifference);

            int damage = Mathf.RoundToInt(speedDifference);

            if (damage < 0)
            {
                damage = 0;
            }

            combat.Damage(damage);
        }
    }

    public void Damage(int damage)
    {
        hp -= damage;
        hpText.text = hp.ToString();

        if (hp <= 0)
        {
            Destroy(gameObject);
        }

    }
}