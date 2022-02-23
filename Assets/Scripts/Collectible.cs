using System;   
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    // A reference to your score text GameObject
    public Text score;
    // How much this particular collectible is worth (score)
    public int scoreAmount;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Get the current score
            int newScore = Int32.Parse(score.text) + scoreAmount;
            // Save the current score to be used across multiple scenes.
            PlayerPrefs.SetInt("score", newScore);
            // Display the newScore in the UI
            score.text = newScore.ToString();
            // Make the Collectible disappear
            Destroy(gameObject);
        }
    }
}