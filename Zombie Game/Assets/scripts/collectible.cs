using UnityEngine;

public class collectible : MonoBehaviour
{
    public GameObject[] collectiblezones;
    public GameObject[] colobj;
    public float startTime = 0.5f; 
    public float endTime = 1.5f; 
    public int startRate = 1; 
    public int endRate = 2;
    void Start()
    {
        InvokeRepeating("spawnZombie", 
            Random.Range(startTime,endTime), 
            Random.Range(startRate,endRate));
    }

    void spawnZombie()
    {
        int colindex = Random.Range(0, colobj.Length); 
        int zindex = Random.Range(0, collectiblezones.Length); 
        Vector3 pos = collectiblezones[zindex].transform.position; 
        Instantiate(colobj[colindex], pos, colobj[colindex].transform.rotation);
    }

    
}
