using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coinsCollected = 0;
    
    [SerializeField] Text coinsText;
    [SerializeField] AudioSource collectionSound;

    private void Start()
    {
        coinsText.text = "Coins: " + coinsCollected;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            collectionSound.Play();
            Destroy(other.gameObject);
            coinsCollected++;
            coinsText.text = "Coins: " + coinsCollected;
        }
    }
}