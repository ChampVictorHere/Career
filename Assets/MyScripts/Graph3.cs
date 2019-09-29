using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Graph3 : MonoBehaviour
{
    public int Graduates;
    public int GladGraduate;
    public Text procText;
    int height = 1;

    public Image[] subjects;
    private RectTransform rectTransfrom;
    private RectTransform rectTransfrom2;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        int chisloEnd = (GladGraduate * 100) / Graduates;
        procText.text = chisloEnd.ToString()+"%";
        rectTransfrom = subjects[0].GetComponent<RectTransform>();
        rectTransfrom2 = subjects[1].GetComponent<RectTransform>();

        Debug.Log(rectTransfrom.sizeDelta);  // получаем размер  типа Vector2
        Debug.Log(rectTransfrom2.sizeDelta);

        rectTransfrom.sizeDelta = new Vector2(150, height * (Graduates/10)); // задаем размер   new Vectro2 (width, height)
        rectTransfrom2.sizeDelta = new Vector2(150, height * (GladGraduate/10)); // задаем размер   new Vectro2 (width, height)
    }
}
