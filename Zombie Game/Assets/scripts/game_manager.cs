using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.Rendering;

public class game_manager : MonoBehaviour
{
    public GameObject selectedZombie;
    public GameObject[] zombies;
    public Vector3 selectedSize;
    private InputAction left, right, jump;

    private int selectedIndex = 0;
    public Vector3 pushForce;
    public TMP_Text timerText;

    private float time = 0;

    private int score;
    public TMP_Text scoreText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SelectZombie(0);
        left = InputSystem.actions.FindAction("Prev Zombie");
        right = InputSystem.actions.FindAction("Next Zombie");
        jump = InputSystem.actions.FindAction("Jump");
        
        UpdateScore(0);
    }

    void SelectZombie(int index)
    {
        if (selectedZombie != null)
        {
            selectedZombie.transform.localScale = Vector3.one;
        }
        selectedZombie = zombies[index];
        selectedZombie.transform.localScale = selectedSize;
        Debug.Log("Selected Zombie:" + selectedZombie.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (left.triggered)
        {
            selectedIndex--;
            if (selectedIndex < 0)
            {
                selectedIndex = zombies.Length-1;
            }
            SelectZombie(selectedIndex);
        }
        if (right.triggered)
        {
            selectedIndex++;
            if (selectedIndex >= zombies.Length)
            {
                selectedIndex = 0;
            }
            SelectZombie(selectedIndex);
        }

        if (jump.triggered)
        {
            Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
            rb.AddForce(pushForce);
            Debug.Log("Jump"); 
            
        }
        time += Time.deltaTime;
        timerText.text = "Time:" + time.ToString("F") + "s";
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }
}
