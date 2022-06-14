using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] private AudioClip hurt, deadSound;
    public float currentHelath { get; private set; }
    private Animator anim;
    static bool dead;

    private void Awake()
    {
        currentHelath = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHelath = Mathf.Clamp(currentHelath - _damage, 0, startingHealth);
        
        if (currentHelath > 0)
        {
            
            anim.SetTrigger("hurt");
            SoundManager.Instance.PlaySound(hurt);
        }
        else
        {
            if (!dead)
            {
                SoundManager.Instance.PlaySound(deadSound);
                anim.SetTrigger("isDead");
                anim.SetBool("dead",true);
                GetComponent<MovementScript>().enabled = false;
                dead = true;
                anim.enabled = false;
                SceneManager.LoadScene(4);
            }

        }
        
    }
    

    public void AddHealth(float _value)
    {
        currentHelath = Mathf.Clamp(currentHelath + _value, 0, startingHealth);

    }

    
}
