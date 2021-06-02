using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	float v;
	float h;
    float yRotate;

    Animator anim;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");

        rb.velocity = transform.forward * v* 5f;
        transform.rotation = Quaternion.Euler(0, another_script.sens, 0);

        

        if(v!=0)
        {
            anim.SetBool("isRun", true);
        }else
        {
            anim.SetBool("isRun", false);
        }

        if(Input.GetMouseButtonDown(0))
      	{
      		anim.SetTrigger("isAttack");
      	}

    }
}
