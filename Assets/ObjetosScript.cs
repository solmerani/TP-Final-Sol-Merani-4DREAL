using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosScript : MonoBehaviour
{
    public float botonIzquierdo;
    public float botonDerecho;
    public int currentIndex = 0;
    public GameObject[] assets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ShowPreviousAsset();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ShowNextAsset();
        }

        
    }
    void ShowNextAsset()
    {
        assets[currentIndex].SetActive(false);
     currentIndex =   (currentIndex + 1) % assets.Length;
        assets[currentIndex].SetActive(true);


    }

    void ShowPreviousAsset()
    {
        assets[currentIndex].SetActive(false);
        currentIndex = (currentIndex - 1) % assets.Length;
        assets[currentIndex].SetActive(true);
    }

}
