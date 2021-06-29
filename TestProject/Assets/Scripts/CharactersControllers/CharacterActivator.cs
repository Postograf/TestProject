using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;

public class CharacterActivator : MonoBehaviour
{
    [SerializeField] private AnimatedCharacter _character;

    private void Update()
    {
        if (Input.touchCount > 0 && !EventSystem.current.IsPointerOverGameObject(Input.touches[0].fingerId))
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                _character.PlayAnimation();
            }
        }
    }
}
