using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Frostbolt : MonoBehaviour
{
    public Transform firePoint;
    public GameObject frostbolt;
    private bool allowFire = true;

    void Update()
    {
        if (Input.GetKeyDown("space") && (allowFire))
        {
            SoundManagerScript.PlaySound("shootSound");
            Shoot();
            StartCoroutine(FireWaitTime());
        }
    }

    void Shoot()
    {
        Instantiate(frostbolt, firePoint.position, firePoint.rotation);
    }

    private IEnumerator FireWaitTime()
    {
        allowFire = false;
        yield return new WaitForSeconds(0.5f); // Time between firing
        allowFire = true;
    } 
}
