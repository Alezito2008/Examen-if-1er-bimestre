using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaDeTaxis : MonoBehaviour
{
    public int unidades;
    public int diasTrabajados;

    readonly int KM_POR_LITRO = 15;
    readonly int KM_POR_DIA = 90;

    readonly int PRECIO_COMBUSTIBLE = 130;
    readonly float PRECIO_COMBUSTIBLE_DESCONTADO = 130 * .8f;

    // Start is called before the first frame update
    void Start()
    {
        if (diasTrabajados < 5)
        {
            Debug.Log("La cantidad de dìas trabajados no puede ser menor a 5");
            return;
        } else if (unidades < 1)
        {
            Debug.Log("La cantidad de unidades no debe ser menor a 1");
            return;
        }

        float precio_final;

        int kilometros_totales = KM_POR_DIA * unidades * diasTrabajados;
        int litros_gastados = kilometros_totales / KM_POR_LITRO;

        if (litros_gastados <= 100)
        {
            precio_final = litros_gastados * PRECIO_COMBUSTIBLE;
        } else {
            precio_final = 100;
            precio_final += (litros_gastados - 100) * PRECIO_COMBUSTIBLE_DESCONTADO;
        }

        Debug.Log($"Una flota de {unidades} unidades trabajando durante {diasTrabajados} dìas implicará un gasto de ${precio_final} pesos en concepto de combustible");
        if (litros_gastados > 100) {
            Debug.Log($"Se aplicó un descuento del 20% ahorrando ${(litros_gastados * PRECIO_COMBUSTIBLE) - precio_final} pesos.");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
