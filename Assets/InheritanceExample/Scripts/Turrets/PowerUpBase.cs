using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    private bool isTimerOn = false;
    [SerializeField] private AudioClip _hitSound;
    [SerializeField] protected float PowerupDuration = 5f;

    //hit code can be reused
    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            OnHit();
        }
    }

    protected abstract void OnHit();

    private IEnumerator Timer()
    {
        isTimerOn = true;
        //Debug.Log("before");
        yield return new WaitForSeconds(PowerupDuration);
        //Debug.Log("after");
        isTimerOn = false;
    }

}
