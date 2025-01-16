using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2, bool> OnMove = new UnityEvent<Vector2, bool>();
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        bool jump = false;

        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
            Debug.Log("up");
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
            Debug.Log("down");
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
            Debug.Log("right");
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
            Debug.Log("left");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }
        OnMove?.Invoke(inputVector, jump);
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputXZPlane);
    }
}
