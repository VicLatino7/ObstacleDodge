using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 15f;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use WASD or arrow keys to move the player.");
        Debug.Log("Do not bump into walls or obstacles!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
