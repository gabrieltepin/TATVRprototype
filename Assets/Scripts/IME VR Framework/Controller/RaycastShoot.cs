using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShoot : MonoBehaviour
{

    public float damage = 20f;
    public float range = 200f;

    public Camera fpsCam;

    public GameObject hitEffect;
    
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }    
    }

    public void Shoot() {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit)) {
            Debug.Log(hit.transform.name);

            GameObject hitGo = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(hitGo, 0.5f);
        }
    }
}
