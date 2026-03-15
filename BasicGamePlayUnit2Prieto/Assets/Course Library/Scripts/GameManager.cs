using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int playerLives = 3;
    private int score = 0;
    public GameObject PlayerPrefab;
    public GameObject SpawnManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Player Lives : 3");
        Debug.Log("Score : 0");
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void AddLives(int value)
    {
        playerLives += value;
        if (playerLives <= 0)
        {
            Debug.Log("Game Over! Your precious farms were eaten!");
            Destroy(PlayerPrefab);
            Destroy(SpawnManager);
        }
        Debug.Log("Lives : " + playerLives);
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score : " + score);
    }
}