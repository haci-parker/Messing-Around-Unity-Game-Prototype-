using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package"))
        {
            Debug.Log("Package is got");
        }

        if (collision.CompareTag("Customer"))
        {
            Debug.Log("Customer is here");
        }
    }
}
