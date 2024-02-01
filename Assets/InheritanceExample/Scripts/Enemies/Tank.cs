using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tank : EnemyBase
{
    bool isTimerOn = false;
    protected override async void OnHit()
    {
        if (isTimerOn)
        {
            base.MoveSpeed = 0.05f;
        } else if (!isTimerOn)
        {
            base.MoveSpeed = 0;
            StartCoroutine(Timer());
            Debug.Log("reached");
        }
        //yield return new WaitForSeconds(1f);
        
    }

    private IEnumerator Timer()
    {
        isTimerOn = true;
        //Debug.Log("before");
        yield return new WaitForSeconds(1f);
        //Debug.Log("after");
        base.MoveSpeed = 0.05f;
        isTimerOn = false;
    }

    public override void Kill()
    {
        //TODO put code you want to happen before disable here

        // this runs the base method AND what's above it here
        base.Kill();
    }
}
