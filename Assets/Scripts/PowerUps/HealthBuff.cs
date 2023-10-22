using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used this video (https://www.youtube.com/watch?v=PkNRPOrtyls&t=698s) to help code this
[CreateAssetMenu(menuName = "Powerups/HealthBuff")] //organizing the different powerups in our asset menu
public class HealthBuff : PowerUpEffect
{
    public float amount;
    public override void Apply(GameObject target) //overrides the function in PowerUpEffect
    {
        target.GetComponent<PlayerHealth>().health += amount; //we get the health component from PlayerHealth so we can add our buff amount to it
    }
}
