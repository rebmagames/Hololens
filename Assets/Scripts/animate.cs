using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour
{
    [SerializeField]
    Animator anim;
 

    public void playAnimation()
    {
        anim.Play("Scene");
    }
}
