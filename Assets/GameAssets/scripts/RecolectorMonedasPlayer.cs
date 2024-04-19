using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectorMonedasPlayer : MonoBehaviour
{
    public string labelMoneda;
    public AudioClip sonidoRecoleccion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(labelMoneda)){
            GameObject.Find("GameManager")?.GetComponent<GameManager>().AddCoin();
            if (sonidoRecoleccion) 
            {
                AudioSource.PlayClipAtPoint(sonidoRecoleccion, transform.position);
            }
            Destroy(collision.gameObject);
        }
    }
}
