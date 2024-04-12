using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected float shootDelay = 1f;
    [SerializeField] protected float shootTimer = 0f;
    [SerializeField] private int bulletType=0;

    void Update()
    {
        Shooting();
    }
    protected virtual void Shooting(){
        float shooting=inputManager.Instance.OnFiring;
        if(this.shootTimer < this.shootDelay) shootTimer += Time.deltaTime;

        if(shooting == 0) return;
        if(this.shootTimer < this.shootDelay) return;
        this.shootTimer = 0;

        Vector3 spawnPos = transform.position;
        Quaternion rotation = transform.parent.rotation;
        BulletSpawner.Instance.Spawn(bulletType,spawnPos, rotation);
        
    }
}

