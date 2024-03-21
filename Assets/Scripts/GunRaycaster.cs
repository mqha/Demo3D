using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRaycaster : MonoBehaviour
{
    public GameObject hitMakerPrefab;
    public Camera aimingCamera;
    public LayerMask layerMask;
    public int damage;

    public void PerformRaycasting()
    {
        Ray aimingRay = new Ray(aimingCamera.transform.position, aimingCamera.transform.forward);
        if(Physics.Raycast(aimingRay, out RaycastHit hitInfo, 1000f, layerMask))
        {
            Quaternion effectRotation = Quaternion.LookRotation(hitInfo.normal);
            Instantiate(hitMakerPrefab, hitInfo.point, effectRotation);
            DeliverDamage(hitInfo);
        }
    }

    public void DeliverDamage(RaycastHit hitInfo)
    {
        Health health = hitInfo.collider.GetComponent<Health>();
        if(health != null)
        {
            health.TakeDamage(damage);
        }
    }
}