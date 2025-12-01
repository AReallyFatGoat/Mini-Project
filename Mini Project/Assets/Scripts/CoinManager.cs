using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private GameObject[] coins = new GameObject[18];
    private float[] coinTimers = new float[18];
    private float respawnTimer = 5f;

    void Start()
    {
        
    }
    void Update()
    {
        for (int i = 0; i < coins.Length; i++)
        {
            if (coins[i].activeSelf)
            {
                coinTimers[i] = 0f;
            }
            coinTimers[i] += Time.deltaTime;
            if (coinTimers[i] > respawnTimer)
            {
                coins[i].SetActive(true);
            }
        }
    }
}
