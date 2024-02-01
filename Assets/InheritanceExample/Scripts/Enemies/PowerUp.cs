using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUp : PowerUpBase
{
    private bool isTimerOn = false;
    [SerializeField] public static float PowerupSpeed = 1f;
    [SerializeField] protected float PowerupDuration = 1f;

    protected override void OnHit()
    {
        if (!isTimerOn)
        {
            Debug.Log("powerup hit");
            StartCoroutine(Timer());
        }
    }

    private IEnumerator Timer()
    {
        isTimerOn = true;
        //Debug.Log("before");
        PowerupSpeed = 4f;
        yield return new WaitForSeconds(PowerupDuration);
        Debug.Log("after");
        isTimerOn = false;
        PowerupSpeed = 1f;
        gameObject.SetActive(false);
    }
}
