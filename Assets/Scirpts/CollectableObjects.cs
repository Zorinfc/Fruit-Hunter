using UnityEngine;

public class CollectableObjects : MonoBehaviour
{
    [SerializeField] private AudioClip collected;
    [SerializeField] private int collectableValue;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            SoundManager.Instance.PlaySound(collected);
            col.GetComponent<Score>().ChangeScore(collectableValue);
            gameObject.SetActive(false);
        }
    }
}
