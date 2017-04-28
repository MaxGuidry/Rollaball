using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {


    public GameObject player;
    private Vector3 offset;
    private Vector2 playervelo;
	// Use this for initialization
	void Start () {
        offset = this.transform.position - player.transform.position;
        playervelo = Vector3.zero;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        this.transform.position = player.transform.position + offset;
        Vector3 axis = new Vector3(0, 1, 0);
        playervelo = new Vector2(player.GetComponent<Movement>().velocity.normalized.x, player.GetComponent<Movement>().velocity.normalized.z);
        Vector2 n = new Vector2(this.transform.forward.x, this.transform.forward.normalized.z);
        float dot = Vector3.Dot(playervelo.normalized, n.normalized);
        float acosdot = Mathf.Acos(dot);
        float angle = acosdot / (playervelo.normalized.magnitude * n.normalized.magnitude);
        Debug.Log(angle);
        Quaternion rotator = new Quaternion(0, Mathf.Sin(angle / 100f), 0, Mathf.Cos(angle / 100f));
        this.transform.rotation = rotator * this.transform.rotation;

    }
}
