using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBomb : MonoBehaviour
{
    [SerializeField]
    GameObject bombParticle;
    Rigidbody rb;
    public float thrust;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, thrust, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(bombParticle, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
