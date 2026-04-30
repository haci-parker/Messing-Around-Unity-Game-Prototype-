using UnityEngine;

public class Customer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Customer"))
        {
            Debug.Log("Driver is here");
            Destroy(collision.gameObject,0.5f);
        }
    }
}
