using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    private static JunkSpawner instance;
    public static JunkSpawner Instance {get=>instance;}
    

    void Awake()
    {
        JunkSpawner.instance=this;
    }
    void Start()
    {
        this.Spawn();
        
    }
    public void Spawn(){
        Transform prefab= this.prefabs[0];
        
        Transform newPrefab = this.GetObjectFromPool(prefab);
        Vector3 position= SpawnPoint.Instance.GetRandomPoint().position;
        Quaternion rotation=transform.rotation;
        newPrefab.SetPositionAndRotation(position,rotation);
        newPrefab.parent =this.holder;
        newPrefab.gameObject.SetActive(true);
        Invoke(nameof(Spawn),1f);
    }
}
