using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{

    public new Rigidbody2D rigidbody { get; private set; }

    public float speed = 500f;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SetRandomTrajectory), 1f);
    }

    private void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-0.8f, 0.8f);
        force.y = -1f;

        this.rigidbody.AddForce(force.normalized * this.speed);
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}