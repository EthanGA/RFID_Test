using UnityEngine;

public class FollowBall : MonoBehaviour {

    public GameObject ball;     
    private Vector3 offset;       

    void Start () 
    {
        offset = transform.position - ball.transform.position;
    }
    
    void LateUpdate () 
    {
        transform.position = ball.transform.position + offset;
    }
}