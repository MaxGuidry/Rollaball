using UnityEngine;
using System.Collections;

public class Seek : MonoBehaviour {

    public GameObject target;
    private float maxVelo = 10;
    private Vector3 position;
    private Vector3 velocity;
    private Vector3 acceleration;
    private Vector3 forceapplied;
	// Use this for initialization
	void Start () {
        position = this.transform.position;
        velocity = Vector3.zero;
        acceleration = Vector3.zero;
        forceapplied = Vector3.zero;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        AddForce(Seeks());
        Updateinfo();
        this.transform.position = position;
	}
    public Vector3 Seeks()
    {
        Vector3 dist = target.transform.position - this.transform.position;
        Vector3 dir = dist.normalized;
        return (dir * maxVelo );
    }
    public void AddForce(Vector3 force)
    {
        forceapplied += force;
    }
    public void Updateinfo()
    {
        acceleration = forceapplied;
        forceapplied = Vector3.zero;
        velocity += (acceleration * Time.deltaTime );
        if(velocity.magnitude > maxVelo)
        {
            velocity = velocity.normalized * maxVelo;
        }
        position += (velocity * Time.deltaTime);
    }
}
