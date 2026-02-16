using UnityEngine;
using System.Collections; 
using System.Collections.Generic; 

public class createobj : MonoBehaviour
{
    private game_manager GameManager;
    public int pointvalue = 1;
    public GameObject ps;
    public float RotationSpeedmax = 50f;
    public float RotationSpeedmin = 10f;
    void Start()
    {
        GameManager = GameObject.Find("Game Manager").GetComponent<game_manager>();
        
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            GameObject exp = Instantiate(ps);
            exp.transform.position = transform.position;
            
            Destroy(gameObject);
            GameManager.UpdateScore(pointvalue);
        }
        
        
        
    }
    
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Random.Range(RotationSpeedmin, RotationSpeedmax)* Time.deltaTime);
    }
}
