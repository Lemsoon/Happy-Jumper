using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectJump : MonoBehaviour
{
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collider2D col)
    {
        _animator.SetBool("JumpedOn", true);

    }

    void NotJumped(Collider2D col)
    {
        _animator.SetBool("JumpedOn", false);
    }
}
