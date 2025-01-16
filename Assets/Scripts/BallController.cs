using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidBody;
    public float ballSpeed = 2f;
    
    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed);
    }
}
