using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationHandler : MonoBehaviour
{
    Animator _animator;

    void Start() => _animator = GetComponent<Animator>(); 
    void StopAnim()
    {
        _animator.SetBool("Hit", false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        _animator.SetBool("Hit", true);
    }
}
