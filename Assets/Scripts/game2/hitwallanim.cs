using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitwallanim : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints;
    private Animator anim;

    private enum MovementState{ idle, lefthit, righthit }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        UpdateAnimationUpdate();
        
    }

    private void UpdateAnimationUpdate()
    {
        MovementState state;

        if (transform.position == waypoints[0].transform.position)
        {
            state = MovementState.lefthit;
        }

        else if (transform.position == waypoints[1].transform.position)
        {
            state = MovementState.righthit;
        }

        else
        {
            state = MovementState.idle;
        }

        anim.SetInteger("state", (int)state);
    }
}
