using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private int sceneIndex;
    private void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
