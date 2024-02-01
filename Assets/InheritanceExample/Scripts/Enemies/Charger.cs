using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Charger : EnemyBase
{
    [SerializeField] private GameObject PowerUp;
    protected override void OnHit()
    {
        base.MoveSpeed *= 2f;
    }

    public override void Kill()
    {
        //TODO put code you want to happen before disable here
        Instantiate(PowerUp, transform.position, transform.rotation);
        // this runs the base method AND what's above it here
        base.Kill();
    }
}
