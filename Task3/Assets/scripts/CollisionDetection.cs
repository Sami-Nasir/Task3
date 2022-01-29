using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject smallBall;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Vector3 moveRight=new Vector3(transform.position.x,transform.position.y,transform.position.z+4);
        Vector3 moveLeft=new Vector3(transform.position.x,transform.position.y,transform.position.z-4);
         if(other.gameObject.CompareTag("Bullet")){
            Destroy(other.gameObject);
            Destroy(gameObject);
            if(gameObject.CompareTag("Big Ball")){
               Instantiate(smallBall,moveRight,transform.rotation);
               Instantiate(smallBall,moveLeft,transform.rotation);
            }
         }
         
        }
  
}
