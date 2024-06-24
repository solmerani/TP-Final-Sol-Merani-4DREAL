using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosScript : MonoBehaviour
{
    public float botonIzquierdo;
    public float botonDerecho;
    public int currentObjectIndex = 0;
    public GameObject[] objetos;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateAllObjects();
        if (objetos.Length > 0)
        {
            objetos[0].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MostrarSiguienteAsset();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MostrarAnteriorAsset();
        }
    }

    public void MostrarSiguienteAsset()
    {
        currentObjectIndex++;
        if (currentObjectIndex >= objetos.Length)
            {
            currentObjectIndex = 0;
        }
        DeactivateAllObjects();
        objetos[currentObjectIndex].SetActive(true);



    }

    public  void MostrarAnteriorAsset()
    {
        currentObjectIndex--;
        if (currentObjectIndex < 0)
            {
            currentObjectIndex - objetos.Length - 1;
        }
        DeactivateAllObjects();
        objetos[currentObjectIndex].SetActive(true);

    }

    void DeactivateAllObjects()
    {
        foreach (GameObject g in objetos)
        {
            g.SetActive(false);
        }
    }
}
