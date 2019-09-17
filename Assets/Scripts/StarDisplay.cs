using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 300;
    Text starText;

    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public void AddStars(int starsAdded)
    {
        stars += starsAdded;
        UpdateDisplay();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void SpendStars(int amountSpent)
    {
        if (stars >= amountSpent)
        {
            stars -= amountSpent;
            UpdateDisplay();
        }
    }

}
