using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public GameObject bullet;
    private float speed=10f;
    // Start is called before the first frame update
    void Start()
    {   
    }
    // Update is called once per frame
    void Update()
    {  
        transform.Translate(Vector3.up* speed * Time.deltaTime);
    }
}
