using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] AudioSource deathSound;
    bool dead = false;

    private void Update()
    {
        if (transform.position.y < -5f && !dead)
        {
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy" && !dead)
        {
            Die();
        }
    }

    void Die()
    {
        dead = true;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
        deathSound.Play();
        FindAnyObjectByType<GameManager>().ShowGameOver();
    }
}