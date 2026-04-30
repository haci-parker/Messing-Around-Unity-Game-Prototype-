using UnityEngine;

public class Customer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Customer"))
        {
            Debug.Log("Customer is here");
        }
    }
}
