using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 xaxis = new Vector3(1, 0, 0);
        Quaternion qx = new Quaternion(Mathf.Sin(Time.deltaTime / 2f) * xaxis.x, Mathf.Sin(Time.deltaTime / 2f) * xaxis.y, Mathf.Sin(Time.deltaTime / 2f) * xaxis.x, Mathf.Cos((Time.deltaTime) / 2f));
        Quaternion rotated = qx * this.transform.rotation;
        Vector3 yaxis = new Vector3(0, 1, 0);
        Quaternion qy = new Quaternion(Mathf.Sin(Time.deltaTime / 1f) * yaxis.x, Mathf.Sin(Time.deltaTime / 1f) * yaxis.y, Mathf.Sin(Time.deltaTime / 1f) * yaxis.x, Mathf.Cos((Time.deltaTime) / 2f));
        rotated = qy * rotated;
        Vector3 zaxis = new Vector3(0, 0, 1);
        Quaternion qz = new Quaternion(Mathf.Sin(Time.deltaTime / 2f) * zaxis.x, Mathf.Sin(Time.deltaTime / 2f) * zaxis.y, Mathf.Sin(Time.deltaTime / 2f) * zaxis.x, Mathf.Cos((Time.deltaTime) / 2f));
        rotated = qz * rotated;
        this.transform.rotation = rotated;
        
    }
}
