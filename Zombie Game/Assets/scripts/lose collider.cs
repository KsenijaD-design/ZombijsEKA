using UnityEngine;

public class losecollider : MonoBehaviour
{
    public game_manager GameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager = GameObject.Find("Game Manager").GetComponent<game_manager>();
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Zombie"))
        {
            Destroy(other.gameObject);
            GameManager.End();
        }
    }
}
