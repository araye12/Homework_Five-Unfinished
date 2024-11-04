using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarbineShoot : MonoBehaviour
{
    public float rayDistance = 100f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // "Fire1" is usually mapped to the left mouse button
        {
            ShootRay();
        }
    }

    void ShootRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            Debug.Log("I hit an object");

            // You can add additional logic here, such as dealing damage to the hit object.
        }
    }
}

