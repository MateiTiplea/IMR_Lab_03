using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectCollision : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private int MULTIPLIER = 100;
    // Start is called before the first frame update
    void Start()
    {
        this.score = 0;
        this.scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        Transform throwPositionOfObject = collision.gameObject.GetComponent<detectGrabLeave>().throwPosition;
        float distanceFromThrow = Vector3.Distance(throwPositionOfObject.position, transform.position);
        
        int points = (int) (MULTIPLIER * distanceFromThrow);
        this.score += points;
        this.scoreText.text = "Score: " + score;
    }
}
