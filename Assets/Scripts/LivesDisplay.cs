using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int lives = 5;

    Text livesText;
    private void Start()
    {
        livesText = GetComponent<Text>();
        UpdateText();
    }

    private void UpdateText()
    {
        livesText.text = lives.ToString();
    }

    public void AddPlayerHealth(int amount)
    {
        lives += amount;
        UpdateText();
    }

    public void RemovePlayerHealth(int amount)
    {
        lives -= amount;
        lives = Mathf.Clamp(lives, 0, 100);
        UpdateText();

        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
