using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    int totalPackages = 0;
    [SerializeField] float delayTime = 0.5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package"))
        {
            if(hasPackage==false){
            hasPackage = true;
            Debug.Log("Package is got");
            Destroy(collision.gameObject,delayTime);
            totalPackages += 1;
            Debug.Log("Total packages:" + totalPackages);
            }
        }

        if (collision.CompareTag("Customer") && hasPackage == true)
        {
            Debug.Log("Package is delivered");
            totalPackages = 0;
            hasPackage = false;
        }
    }
}
