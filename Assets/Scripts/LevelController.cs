using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel, loseLabel;
    [SerializeField] float winWaitTime = 4;
    [SerializeField] [Range(0, 1)] float slowDownTime = 0.2f;
    int numberOfEnemies = 0;
    bool timerFinished = false;

    private void Start()
    {
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
    }

    public void CountEnemyUp()
    {
        numberOfEnemies++;
    }

    public void CountEnemyDown()
    {
        numberOfEnemies--;

        if (numberOfEnemies <= 0 && timerFinished)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    public void TimerExpired()
    {
        timerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }

    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        yield return new WaitForSeconds(winWaitTime);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }

    public void HandleLoseCondition()
    {
        loseLabel.SetActive(true);
        Time.timeScale = slowDownTime;
    }
}
