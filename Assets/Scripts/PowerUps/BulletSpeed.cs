using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used this video (https://www.youtube.com/watch?v=PkNRPOrtyls&t=698s) to help code this
[CreateAssetMenu(menuName = "Powerups/BulletSpeed")]

public class BulletSpeed : PowerUpEffect
{
    public float amount;
    public override void Apply(GameObject target) //overrides the function in PowerUpEffect
    {
        target.GetComponent<Weapon>().timeBetweenFiring -= amount; //we get the timeBetweenFiring component from Weapon so we can add our buff amount to it
    }
}
