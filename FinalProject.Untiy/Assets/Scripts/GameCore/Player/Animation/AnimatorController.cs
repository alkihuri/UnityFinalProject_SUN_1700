using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AnimatorController : MonoBehaviour
{
    public Animator characterAnim;
    // Start is called before the first frame update
    void Start()
    {
        characterAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            characterAnim.SetBool("iswalk",true);
        }
        else
        {
            characterAnim.SetBool("iswalk",false);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            characterAnim.SetBool("iswalkback",true);
        }
        else
        {
            characterAnim.SetBool("iswalkback",false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            characterAnim.SetBool("iswalkleft",true);
        }
        else
        {
            characterAnim.SetBool("iswalkleft",false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            characterAnim.SetBool("iswalkright",true);
        }
        else
        {
            characterAnim.SetBool("iswalkright",false);
        }




    }
}
