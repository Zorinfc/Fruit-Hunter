using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;
    
    void Start()
    {
        totalHealthBar.fillAmount = playerHealth.currentHelath / 10;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealthBar.fillAmount = playerHealth.currentHelath / 10;
    }
}
