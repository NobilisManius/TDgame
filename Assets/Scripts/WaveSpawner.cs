using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{

    public Transform enemyPrefab;
    public Transform enemySpawn;
    public float timeBetwenWaves = 5f;
    public Text waveCountDownText;


    private float countdown = 2f;
    private int waveIndex = 0;


    private void Update()
    {
        
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetwenWaves;
        }

        countdown -= Time.deltaTime;
        waveCountDownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.1f);
        }

    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, enemySpawn.position, enemySpawn.rotation);
    }


}
