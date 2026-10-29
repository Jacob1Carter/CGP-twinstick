using UnityEngine;

public class PowerUpComponent : MonoBehaviour
{
    [SerializeField] private int referenceIndex;
    PowerUpManager powerUpManager;
    private void Start()
    {
        powerUpManager = GameObject.Find("PowerUpManager").GetComponent<PowerUpManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            powerUpManager.powerUpCount[referenceIndex]++;
            Destroy(gameObject);
        }
    }
}
