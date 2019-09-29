using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphs : MonoBehaviour
{
    public int[] places;
    int height = 100;

    public GameObject[] panels; // ваша панель

    private RectTransform rectTransfrom;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < places.Length; i++)
        {
  
            rectTransfrom = panels[i].GetComponent<RectTransform>();

        Debug.Log(rectTransfrom.sizeDelta);  // получаем размер  типа Vector2


            rectTransfrom.sizeDelta = new Vector2(50, height); // задаем размер   new Vectro2 (width, height)
            height += 100;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
