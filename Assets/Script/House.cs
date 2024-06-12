using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House : MonoBehaviour
{
    public GameObject PlanetReff;
    public GameObject Effect;
    Vector3 planetScale;
 

    private void Start()
    {
        PlanetReff = GameObject.Find("Planet");
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(Effect, transform.position, transform.rotation);
            if(PlanetReff.transform.localScale.x <= 0.005f)
            {
                SceneManager.LoadScene("GameOver");
                Debug.Log("GameOver");
            }
            else
            {
                planetScale = PlanetReff.transform.localScale - new Vector3(0.0005f, 0.0005f, 0.0005f);
                Debug.Log("EX");
                PlanetReff.transform.localScale = planetScale;
                Destroy(gameObject);
            }
           
        }
    }
    
}
