using UnityEngine;

public class collectible : MonoBehaviour
{
    public GameObject[] collectiblezones;
    public GameObject[] colobj;

    public float startTime = 0.5f;
    public float endTime = 5f;

    public int startRate = 1;
    public int endRate = 5;
    public int maxCollectibles = 3;

    public int count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
            //InvokeRepeating("spawnZombie", Random.Range(startTime,endTime),
                //Random.Range(startRate,endRate));
                
    }
    

    // Update is called once per frame
    void Update()
    {
        if (colobj == null)
        {
            addCollectible();
        }
       
    }

    public void addCollectible()
    {
        //choose what one of obj to take
        int colindex = Random.Range(0, colobj.Length);
        int zindex = Random.Range(0, collectiblezones.Length);
        
        Vector3 pos = collectiblezones[zindex].transform.position;
        
        Instantiate(colobj[colindex], pos, colobj[colindex].transform.rotation);
    }
}
