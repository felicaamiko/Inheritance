using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUp : PowerUpBase
{
    protected override void OnHit()
    {

        Debug.Log("powerup hit");
        gameObject.SetActive(false);
    }

}
