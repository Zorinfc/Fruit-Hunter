using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    [SerializeField] private float healthValue;
    [SerializeField] private AudioClip collect;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            SoundManager.Instance.PlaySound(collect);
            col.GetComponent<Health>().AddHealth(healthValue);
            gameObject.SetActive(false);
            
        }
    }
}
