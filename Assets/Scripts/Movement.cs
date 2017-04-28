using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    private int count;
    public Text countText;
    public Text winText;
    [HideInInspector]
    public Vector3 velocity;
    [HideInInspector]
    public Vector3 acceleration;
    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update () {
	
        
	}

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(horizontal, 0, vertical);
        acceleration = force;
        velocity += (acceleration * Time.deltaTime);
        gameObject.transform.position += velocity * Time.deltaTime * speed;
    }
    void OnTriggerEnter(Collider g)
    {
        Seek s = g.gameObject.GetComponent<Seek>();
        if (g.CompareTag("collectable") && s.enabled == false)
        {
            //GameObject.Destroy(g.gameObject);
            
            s.enabled = true;
            count++;
            SetCountText();

        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count>=20)
        {
            winText.text = "You Win!";
        }
    }
}
