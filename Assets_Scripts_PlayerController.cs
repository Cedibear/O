using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Player playerData;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ApplySpecialAbility();
    }

    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * moveSpeed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    void ApplySpecialAbility()
    {
        switch (playerData.specialAbility)
        {
            case SpecialAbility.SpeedBoost:
                moveSpeed *= 1.5f;
                break;
            case SpecialAbility.PrecisionShot:
                // Implement precision shot logic
                break;
            case SpecialAbility.EnhancedDefense:
                // Implement enhanced defense logic
                break;
            case SpecialAbility.DribblingMaster:
                // Implement dribbling master logic
                break;
        }
    }
}