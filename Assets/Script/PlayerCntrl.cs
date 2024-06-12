using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCntrl : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;
    [SerializeField] float rotationSpeed = 100f;
    public float currentScore;
    public float ScoreIncTimer;
    float timePassed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Vertical") != 0)
        //Input.GetAxis("Vertical")

        {
            timePassed += Time.deltaTime;
            if(ScoreIncTimer < timePassed)
            {
                currentScore += 1;
                timePassed = 0;
                PlayerPrefs.SetFloat("CurrentScore", currentScore);
                if ((currentScore % 10) == 0)
                {
                    speed += 0.25f;
                }
                if(currentScore > PlayerPrefs.GetFloat("HighScore"))
                {
                    PlayerPrefs.SetFloat("HighScore", currentScore);
                }
            }
            transform.Translate(Vector3.forward * Time.deltaTime * -speed * 1);
            
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);     
        }
        

    }
}
