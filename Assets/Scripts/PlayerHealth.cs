using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    private float health;
    public bool isRegenerating = false;
    public bool isInvincible = false;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        health = Mathf.Clamp(health, 0, maxHealth);
        if (isRegenerating)
        {
            health += 2.5f * Time.deltaTime;
        }

        if (health <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void TakeDamage(float amount)
    {
        if (!isInvincible)
        {
            health -= amount;
        }
    }
}
