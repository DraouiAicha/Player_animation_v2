using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    float velocity = 0.0f;
    public float acceleration = 0.1f;
    public float deceleration = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        if(forwardPressed && velocity < 1) {
            velocity += Time.deltaTime * acceleration;
        }
        if(!forwardPressed && velocity > 0) {
            velocity -= Time.deltaTime * deceleration;
        }
        if(!forwardPressed && velocity < 0) {
            velocity = 0.0f;
        }
        animator.SetFloat("Velocity", velocity);
    }
}
