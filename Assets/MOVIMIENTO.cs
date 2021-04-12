using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVIMIENTO : MonoBehaviour
{
    public float VelosidadMovimiento = 5.0f;
    public float SpedJump = 3f;
    public float velosidadRotacion;
    public Animator anim;
    public bool  Jump;
    public float x, y;





    void Start()
    {
        anim = GetComponent<Animator>();  
    }
    // Update is called once per frame
    void Update()
    {

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velosidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * VelosidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
