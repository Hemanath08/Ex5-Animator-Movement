using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Animator animator;
    public float InputX;
    public float InputY;

    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputY = Input.GetAxis("Vertical");

        animator.SetFloat("InputX", InputX);
        animator.SetFloat("InputY", InputY);
    }
}
