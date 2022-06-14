using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    public static int totoalScore;
    public TextMeshProUGUI scoreUI;

 
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    
    private void Update()
    {
        scoreUI.text = " SCORE:" + totoalScore;
        
    }


    
}
