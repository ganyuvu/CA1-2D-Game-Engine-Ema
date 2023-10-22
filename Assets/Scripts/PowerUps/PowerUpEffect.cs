using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script will let me build different type of powerups out of, used this video to help code this (https://www.youtube.com/watch?v=PkNRPOrtyls&t=698s)
public abstract class PowerUpEffect : ScriptableObject //a scriptable object allows us to store large quantaties of shared data
{
    public abstract void Apply(GameObject target); // this is essentailly a template for what i want my powerup to be
}
