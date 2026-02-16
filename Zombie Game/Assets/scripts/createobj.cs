using UnityEngine;
using System.Collections; 
using System.Collections.Generic; 

public class createobj : MonoBehaviour
{
    private game_manager GameManager;
    public int pointvalue = 1;
    public ParticleSystem ps;
    void Start()
    {
        GameManager = GameObject.Find("Game Manager").GetComponent<game_manager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameManager.UpdateScore(pointvalue);
        Instantiate(ps, transform.position, ps.transform.rotation);
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
