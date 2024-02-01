using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    private bool isTimerOn = false;

    [SerializeField] protected float PowerupDuration = 5f;

    private IEnumerator Timer()
    {
        isTimerOn = true;
        //Debug.Log("before");
        yield return new WaitForSeconds(PowerupDuration);
        //Debug.Log("after");
        isTimerOn = false;
    }

}
