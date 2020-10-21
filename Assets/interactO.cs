using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class interactO : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            animator.SetTrigger("DefaultToGrab");
        }
        if (Input.GetKeyDown("w"))
        {
            animator.SetTrigger("DefaultToPoint");
        }
        if (Input.GetKeyDown("e"))
        {
            animator.SetTrigger("DefaultToMetal");
        }
    }
}
