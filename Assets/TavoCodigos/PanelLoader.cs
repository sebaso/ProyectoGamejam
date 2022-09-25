using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelLoader : MonoBehaviour
{
    public GameObject[] paneles;
    public static int panelactual = 0;
    [HideInInspector] public int panelAnterior;

    // Start is called before the first frame update
    void Start()
    {

    }

    /*
    public void SelectorDePanel(int actual, int nuevo)
    {
        if (!paneles[nuevo].activeSelf) print("aea"); //return;


        //paneles[actual].SetActive
    }
    */

    public void OpenConfig()
    {
        if (paneles[1].activeSelf) return;

        paneles[0].SetActive(false);
        paneles[1].SetActive(true);
        panelAnterior = 0;
        panelactual = 1;

    }

    public void OpenCredits() 
    {
        if (paneles[2].activeSelf) return;

        paneles[0].SetActive(false);
        paneles[2].SetActive(true);
        panelAnterior = 0;
        panelactual = 2;
    }

    public void ReturnPanel()
    {
        int varTemporal = panelAnterior;

        if (paneles[panelAnterior].activeSelf) return;
        paneles[panelactual].SetActive(false);
        paneles[panelAnterior].SetActive(true);
        panelAnterior = panelactual;
        panelactual = varTemporal;


    }

    public void Salir() 
    {
        Debug.Log("salida");
    }

    public void IniciarNivel(int nivel) 
    {

        Debug.Log("se inicia el nivel :");
    }


}
