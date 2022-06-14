using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    [SerializeField] private GameObject endMenu;
    
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
        endMenu.SetActive(false);
    }

    public void resetScore()
    {
        PlayerData.totoalScore = 0;
    }
    
}
