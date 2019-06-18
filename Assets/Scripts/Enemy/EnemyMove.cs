using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -speed);
    }
}
