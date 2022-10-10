using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Collectables : MonoBehaviour
{
    public int coins = 0;
    public TextMeshProUGUI coinsText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins: " + coins;
        if (coins >= 15)
        {
            //Scene WinScreen = SceneManager.GetActiveScene();
            SceneManager.LoadScene("WinScreen");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "Coin")
        {
            Destroy(collision.gameObject);
            coins++;    
        }
    }
}
