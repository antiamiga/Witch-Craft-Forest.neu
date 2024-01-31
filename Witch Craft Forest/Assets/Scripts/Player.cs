using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public bool isOverShieldActive;
    public Color OverShieldColor;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
        
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    public IEnumerator SetResetTimer() //OverShieldTimer sets OverShield effect
    {
        transform.GetChild(0).GetComponent<SpriteRenderer>().color = OverShieldColor;
        yield return new WaitForSeconds(2);
        transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.white;
        isOverShieldActive = false;
    }
}
