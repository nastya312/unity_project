using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
public class PleyerController : MonoBehaviour
{
   
    // Components
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movment;
   

    public static int health = 100;
    public static float moveSpeed = 5f;
   

    void Start()
    {
      
    }

    void Update()
    {
       PlayerMuvment();
      
    }

    void PlayerMuvment()
    {
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);

        animator.SetFloat("Horizontal", movment.x);
        animator.SetFloat("Vertical", movment.y);
        animator.SetFloat("Speed", movment.sqrMagnitude);
    }
}
