using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {


    public GameObject player;
    private Vector3 offset;
    private Vector3 playervelo;
	// Use this for initialization
	void Start () {
        offset = this.transform.position - player.transform.position;
        playervelo = player.transform.position;
        Quaternion q1 = new Quaternion(0, 0, 1, Mathf.PI);
        Quaternion half = q1 * new Quaternion(Mathf.Sin(Mathf.PI / 8), 0, 0, Mathf.Cos(Mathf.PI / 8));
        Quaternion rotated = half * Quaternion.Inverse(q1);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        this.transform.position = player.transform.position + offset;
        //Vector3 axis = new Vector3(0, 1, 0);
        //Quaternion q = new Quaternion(Mathf.Sin(Time.deltaTime / 2f) * axis.x, Mathf.Sin(Time.deltaTime / 2f) * axis.y, Mathf.Sin(Time.deltaTime / 2f) * axis.x, Mathf.Cos((Time.deltaTime) / 2f));
        //Quaternion half = q * this.transform.rotation;
        //this.transform.rotation = half;
        playervelo = playervelo - player.transform.position;
	}
}
