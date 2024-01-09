using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destructionDelay = 1f;
    bool packageCollected = false;
    public Sprite car;
    public Sprite carWithPackage;
    SpriteRenderer spriteRenderer;

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Nice driving titface");
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && packageCollected == false) {
            Debug.Log("Package collected");
            packageCollected = true;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = carWithPackage;
            Destroy(other.gameObject, destructionDelay);
        } else {
            Debug.Log("You already have a package to deliver");
        }
        
        if (other.tag == "Customer" && packageCollected == true) {
            Debug.Log("Package delivered");
            this.gameObject.GetComponent<SpriteRenderer>().sprite = car;
            packageCollected = false;
        }
    }
}
