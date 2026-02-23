using UnityEngine;
using UnityEngine.InputSystem;

public class MAZE : MonoBehaviour
{
    public GameObject maze;
    private InputAction turn;

    public float turnspeed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        turn = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 turnvalue = turn.ReadValue<Vector2>();
        maze.transform.Rotate(new Vector3(turnvalue.x,0,turnvalue.y) 
                              * turnspeed * Time.deltaTime);
        Debug.Log("Turn val x " + turnvalue.x + " y" + turnvalue.y);
    }
}
