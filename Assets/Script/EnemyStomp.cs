using UnityEngine;

public class EnemyStomp : MonoBehaviour
{
    [SerializeField] GameObject enemyToDestroy;
    [SerializeField] float bounceForce = 7f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody playerRb = other.GetComponent<Rigidbody>();
            if (playerRb != null)
            {
                playerRb.linearVelocity = new Vector3(playerRb.linearVelocity.x, bounceForce, playerRb.linearVelocity.z);
            }
            
            Destroy(enemyToDestroy);
        }
    }
}