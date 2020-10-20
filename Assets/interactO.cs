using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class interactO : MonoBehaviour
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
        animator.SetBool("point", false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("q"))
        {
            animator.SetBool("grab", true);
            Task.Delay(1000).ContinueWith((task) => {
                animator.SetBool("grab", false);
            }); //nu prea merge
        }
        if (Input.GetKeyDown("w"))
        {
            animator.SetBool("metal", true);
            Task.Delay(1000).ContinueWith((task) => {
                animator.SetBool("metal", false);
            });
        }
        if (Input.GetKeyDown("e"))
        {
            animator.SetBool("point", true);
            Task.Delay(1000).ContinueWith((task) => {
                animator.SetBool("point", false);
            });
        }
        if (Input.GetKeyDown("r"))
        {
            animator.SetBool("grab", false);
            animator.SetBool("metal", false);
            animator.SetBool("point", false);
        }
    }
}
