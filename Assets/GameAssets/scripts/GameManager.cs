using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textNumeroMonedas;

    private int numeroMonedas = 0;

    public void AddCoin()
    {
        numeroMonedas++;

        if (textNumeroMonedas == null)
        {
            Debug.LogError("El GameManager no está correctamente configurado");
        } else
        {
            textNumeroMonedas.text = numeroMonedas.ToString();
        }
    }
}
