using UnityEngine;

public class BlueBallController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField] float power;
    public bool direction; //true is right
    public bool isActive = false;
    [SerializeField] SphereCollider triggerCollider;

    void Start()
    {
        // StartCoroutine(Jump());

        rb = GetComponent<Rigidbody>();
        Invoke("Move", 2);

    }

    void Move()
    {
        triggerCollider.enabled = true;
        if (direction)
        {
            rb.AddForce(new Vector3(1, 0, 0) * power);
        }
        else
        {
            rb.AddForce(new Vector3(0, 0, -1) * power);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

}
