using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    public float health;

    private void Start()
    {
        health = maxHealth;
    }
}
