using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public abstract class AnimatedCharacter : MonoBehaviour
{
    public abstract void PlayAnimation();
    public abstract void StopAnimation();
}
