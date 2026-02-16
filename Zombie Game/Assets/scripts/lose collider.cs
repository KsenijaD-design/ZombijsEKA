using UnityEngine;

public class losecollider : MonoBehaviour
{
    public game_manager GameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager = GameObject.Find("Game Manager").GetComponent<game_manager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zombie"))
        {
            Destroy(other.gameObject);
            GameManager.End();
        }
    }
}
