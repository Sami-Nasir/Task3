using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    private float start=1.0f;
    private float delay=8.0f;              
    private Vector3 pos;
    GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject",start,delay);
        temp=GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void SpawnObject(){
    int rand= Random.Range(-9,9);
    pos=new Vector3(0,15,rand);
    if(temp!= null){
       Instantiate(prefab,pos,prefab.transform.rotation);
       }
    }
}