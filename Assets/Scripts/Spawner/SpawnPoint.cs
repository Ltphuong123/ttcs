using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private static SpawnPoint instance;
    public static SpawnPoint Instance {get=>instance;}
    [SerializeField] protected List<Transform> points;

    void Awake()
    {
        SpawnPoint.instance=this;
    }
    

    public virtual Transform GetRandomPoint(){
        return this.points[Random.Range(0,this.points.Count)];
    }

}
