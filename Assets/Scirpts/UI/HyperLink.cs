using UnityEngine;

public class HyperLink : MonoBehaviour
{
    public void OpenLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/furkan-sarıkaya-a83553176/");
    }

    public void OpenGitHub(string link)
    {
        Application.OpenURL("https://github.com/Zorinfc");
    }
}
