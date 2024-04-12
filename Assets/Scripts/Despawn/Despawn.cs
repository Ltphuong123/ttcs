using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    [SerializeReference]protected float maxDistance = 20f;

    [SerializeReference]protected Transform mainCameraTransform;
    protected Vector3 initialPosition;
   
    void Start()
    {
        mainCameraTransform = Camera.main.transform;
    }
    void Update(){
        float distanceToCamera = Vector3.Distance(mainCameraTransform.position, transform.position);
        if (distanceToCamera >= maxDistance){
            DespawnObj();
        }
    }
    public virtual void DespawnObj()
    {
       
    }
}
