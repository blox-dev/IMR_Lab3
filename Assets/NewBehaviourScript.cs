using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorMoveScript : MonoBehaviour
{
    public Animator animator;
    public bool grab = false;
    public bool metal = false;
    public bool point = false;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("grab", false);
        animator.SetBool("metal", false);
        animator.SetBool("grab", false);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("q"))
        {
            animator.SetBool("grab", false);
        }
        if (Input.GetKeyDown("w"))
        {
            animator.SetBool("metal", false);
        }
        if (Input.GetKeyDown("r"))
        {
            animator.SetBool("grab", false);
        }
    }
}
