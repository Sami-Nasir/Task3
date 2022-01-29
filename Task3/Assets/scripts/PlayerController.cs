using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public GameObject bullet;
    public float speed=2.0f;
    // Start is called before the first frame update
    void Start()
    {
 
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * horizontalInput * speed * Time.deltaTime);
         if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(bullet,transform.position,transform.rotation);
        }
    }
     private void OnCollisionEnter(Collision other){
         if(other.gameObject.CompareTag("Big Ball")||other.gameObject.CompareTag("Small Ball")){
             Destroy(gameObject);
         }
     }
}
