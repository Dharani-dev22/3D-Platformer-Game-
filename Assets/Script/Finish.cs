using UnityEngine;

public class Finish : MonoBehaviour
{
    private bool levelCompleted = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && !levelCompleted)
        {
            levelCompleted = true;
            FindAnyObjectByType<GameManager>().ShowLevelComplete();
        }
    }
}