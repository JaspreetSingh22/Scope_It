using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject Hole;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.DetachChildren();
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");

        }
        if (collision.gameObject.CompareTag("Planet")) 
        {
            Instantiate(Hole, transform.position, Quaternion.identity);
            Debug.Log("Planet struck");
            Destroy(gameObject); 
        }
            if(collision.gameObject.CompareTag("House"))
        {
            Destroy(gameObject);
        }
        
    }
}
