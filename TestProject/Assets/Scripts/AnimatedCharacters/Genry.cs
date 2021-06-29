using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genry : AnimatedCharacter
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public override void PlayAnimation()
    {
        StopAnimation();
        _animator.Play("Walking");
    }

    public override void StopAnimation()
    {
        _animator.Rebind();
    }
}
