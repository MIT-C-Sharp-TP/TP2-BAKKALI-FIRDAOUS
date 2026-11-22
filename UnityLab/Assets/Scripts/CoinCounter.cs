
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int coins;
    private int coinsToWin;

    void OnEnable()
    {
        Coin.Collected += AddCoin;
    }

    void OnDisable()
    {
        Coin.Collected -= AddCoin;
    }

    void Start()
    {
        coinsToWin = FindObjectsByType<Coin>(
            FindObjectsSortMode.None
        ).Length;

        Debug.Log($"Collect the {coinsToWin} coins!");
    }

    private void AddCoin()
    {
        coins++;

        Debug.Log($"Coins: {coins} / {coinsToWin}");

        if (coins == coinsToWin)
        {
            Debug.Log("All coins collected!");
        }
    }
}
