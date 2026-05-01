using System;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Driver : MonoBehaviour
{
    [SerializeField] float currentSpeed = 5f;
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float boostSpeed = 12f;
    [SerializeField] float regularSpeed = 4f;

    [SerializeField] TextMeshProUGUI boostText;

    void Start()
    {
        boostText.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Booster"))
        {
            currentSpeed = boostSpeed;
            Debug.Log("Speed boost");
            GetComponent<ParticleSystem>().Play();
            boostText.gameObject.SetActive(true);
        }
        else if(collision.CompareTag("Bumper"))
        {
            currentSpeed = regularSpeed;
            GetComponent<ParticleSystem>().Stop();
            boostText.enabled = false;
            Debug.Log("Speed reduced");
        }
    }   

    // Update is called once per frame
    void Update()
    {
        float move = 0f;
        float steer = 0f;
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
            if (Keyboard.current.aKey.isPressed)
        {
                steer = 1f;
            }
            else if (Keyboard.current.dKey.isPressed)
            {
                steer = -1f;
            }
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f; 
            if (Keyboard.current.aKey.isPressed)
            {
                steer = -1f;
            }
            else if (Keyboard.current.dKey.isPressed)
            {
                steer = 1f;
            }
        }

        float moveAmount = move * currentSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0,moveAmount,0);
        transform.Rotate(0, 0, steerAmount);
    }
}
