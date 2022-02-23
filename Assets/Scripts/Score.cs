using UnityEngine;

public class Score : MonoBehaviour
{
    // Reset the score at the start of the game
    void Start()
    {
        // if it's 0th scene (buildIndex == 0)
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {
            // reset the score
            PlayerPrefs.SetInt("score", 0);
        }
        GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetInt("score").ToString();
    }
}