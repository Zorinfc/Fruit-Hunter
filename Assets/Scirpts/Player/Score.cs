using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    // public int score {get; private set;}
    public static Score instance;
    public TextMeshProUGUI scoreUI;
    
    private void Start()
    {
        if (instance == null) instance = this;
    }

    private void Update()
    {
        scoreUI.text = " SCORE:" + PlayerData.totoalScore;
        scoreUI.fontStyle = FontStyles.Bold;
    }

    public void ChangeScore(int value)
    {
        PlayerData.totoalScore += value;
    }
}
