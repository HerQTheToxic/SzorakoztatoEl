using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Healt;
    public float playerSpeed;
    private Rigidbody2D rb;
    private int HP;
    private Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        HP = Healt;
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical"); //fel=1, le=-1
        playerDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    public void Hit()
    {
        if (HP > 1)
            HP--;
        else
            died();
    }
    private void died()
    {
        Destroy(this.gameObject);
    }
}
