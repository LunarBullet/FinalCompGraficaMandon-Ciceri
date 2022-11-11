using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlEffect1 : MonoBehaviour
{
    [SerializeField] ParticleSystem particula;
    Animator animator;
    private int EscudoActive;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        EscudoActive= Animator.StringToHash("escudo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            animator.SetTrigger(EscudoActive);
            if (particula != null)
             
            particula.Play(true);
        }
    }
}
