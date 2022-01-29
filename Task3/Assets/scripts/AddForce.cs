using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public Rigidbody rb;
    public float speed=3.0f; 
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision other){
         if(rb.gameObject.CompareTag("Ground")){
            rb.AddForce(Vector3.up * speed* Time.deltaTime,ForceMode.Impulse);
        }    
        }
}
