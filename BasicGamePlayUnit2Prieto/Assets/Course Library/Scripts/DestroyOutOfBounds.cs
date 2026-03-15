using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 45.0f;
    
    private GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -topBound)
        {
            Destroy(gameObject);
            gameManager.AddLives(-1);
        }
    }

}
