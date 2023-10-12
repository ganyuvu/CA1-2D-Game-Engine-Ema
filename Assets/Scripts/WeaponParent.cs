using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponParent : MonoBehaviour
{
    public Vector2 pointerPosition { get; set; } // creating a getter and a setter so we can use the weapon on another script

    private void Update()
    {
         transform.right = (pointerPosition - (Vector2)transform.position).normalized; // this ensures that the red axis is always used as the pointer

    }
}
