using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGrunt_ia : MonoBehaviour{

    public Transform MinDist, MaxDist;
    [Range(1.0f, 10.0f)] public float Speed;
    private Vector3 moveTo;
    Vector3  Inicial;
    // Start is called before the first frame update
    void Start()
    {
        moveTo=MinDist.position;
        Inicial=transform.position;
    }

    // Update is called once per frame
    void Update(){
        
        transform.position=Vector3.MoveTowards(transform.position, moveTo, 4.0f*Time.deltaTime);
        if(transform.position== MinDist.position){
            moveTo=MaxDist.position;
            transform.Rotate(new Vector3(0,180,0));
        }if (transform.position==MaxDist.position){
            moveTo=MinDist.position;
            transform.Rotate(new Vector3(0,180,0));
        }
    }
}
