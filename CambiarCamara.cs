using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    public Camera panoramica;
    public Camera camaraA;
    public Camera camaraB;
    public Camera camaraC;
    public Camera camara1;

    void Start()
    {
        // Iniciamos con CamaraA como activa (puedes cambiar si quieres otra)
        ActivarCamara(camaraA);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivarCamara(camaraA);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivarCamara(camaraB);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivarCamara(camaraC);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ActivarCamara(camara1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0)) // Ejemplo: panorámica con 0
        {
            ActivarCamara(panoramica);
        }
    }

    void ActivarCamara(Camera camaraActiva)
    {
        // Desactivar todas
        panoramica.gameObject.SetActive(false);
        camaraA.gameObject.SetActive(false);
        camaraB.gameObject.SetActive(false);
        camaraC.gameObject.SetActive(false);
        camara1.gameObject.SetActive(false);

        // Activar solo la elegida
        camaraActiva.gameObject.SetActive(true);
    }
}
