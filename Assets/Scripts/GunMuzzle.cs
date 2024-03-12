using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMuzzle : MonoBehaviour
{
    [SerializeField] private Transform muzzleImage;
    [SerializeField] private float duration;

    private void Start()
    {
        HideMuzzle();
    }

    private void ShowMuzzle()
    {
        muzzleImage.gameObject.SetActive(true);
        float angle = Random.Range(0, 360f);
        muzzleImage.localEulerAngles = new Vector3(0, 0, angle);
        CancelInvoke();
        Invoke(nameof(HideMuzzle), duration);
    }

    private void HideMuzzle()
    {
        muzzleImage.gameObject.SetActive(false);
    }
}
