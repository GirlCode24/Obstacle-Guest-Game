using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float movementSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
    }

    void MoveThePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(xValue, yValue, zValue);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome To Your Game World");
        Debug.Log("Use Arrow Keys or W,A,S,D for Movements");
        Debug.Log("Sike!!! Don't Bump Into The Wall");
    }
}
