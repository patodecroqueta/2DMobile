using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorPlayer : MonoBehaviour
{
    public float velocidadDesplazamiento;
    public float velocidadSalto;
    private float horizontal;

    private Rigidbody2D playerRB2D;
    void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space)){
            playerRB2D.velocity = 
                new Vector2(horizontal * velocidadDesplazamiento, velocidadSalto); 
        } else {
            playerRB2D.velocity = 
                new Vector2(horizontal * velocidadDesplazamiento, playerRB2D.velocity.y);
        }
        
    }
}
