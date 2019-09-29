using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Graphs2 : MonoBehaviour
{
    public Text Gtext, Gtext2, Gtext3, Gtext4;
    int height = 20;
    public Image sk1, sk2, sk3;
    public int[] procs;
    int[] subjectsN;

    public Image[] subjects;

    private RectTransform rectTransfrom;
    // Start is called before the first frame update
    void Start()
    {
        sk2.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        Gtext.text = procs[0].ToString() + "%";   
        Gtext2.text = procs[1].ToString() + "%";
        Gtext3.text = procs[2].ToString() + "%";
        Gtext4.text = procs[3].ToString() + "%";
        if (sk1.color == Color.green)
        {
            procs[0] = 30;
            procs[1] = 25;
            procs[2] = 25;
            procs[3] = 15;
            for (int i = 0; i < procs.Length; i++)
            {
                rectTransfrom = subjects[i].GetComponent<RectTransform>();

                Debug.Log(rectTransfrom.sizeDelta);  // получаем размер  типа Vector2

                rectTransfrom.sizeDelta = new Vector2(100, height * procs[i]);
            }
            if (sk2.color == Color.green)
            {
                procs[0] = 50;
                procs[1] = 42;
                procs[2] = 44;
                procs[3] = 33;
                for (int i = 0; i < procs.Length; i++)
                {
                    rectTransfrom = subjects[i].GetComponent<RectTransform>();

                    Debug.Log(rectTransfrom.sizeDelta);  // получаем размер  типа Vector2

                    rectTransfrom.sizeDelta = new Vector2(100, height * procs[i]);
                }
                if (sk3.color == Color.green)
                {
                    procs[0] = 50;
                    procs[1] = 45;
                    procs[2] = 60;
                    procs[3] = 51;
                    for (int i = 0; i < procs.Length; i++)
                    {
                        rectTransfrom = subjects[i].GetComponent<RectTransform>();

                        Debug.Log(rectTransfrom.sizeDelta);  // получаем размер  типа Vector2

                        rectTransfrom.sizeDelta = new Vector2(100, height * procs[i]);
                    }
                }
                else { }
            }
            else
            {
                if (sk3.color == Color.green)
                {
                    procs[0] = 30;
                    procs[1] = 35;
                    procs[2] = 40;
                    procs[3] = 31;
                    for (int i = 0; i < procs.Length; i++)
                    {
                        rectTransfrom = subjects[i].GetComponent<RectTransform>();

                        Debug.Log(rectTransfrom.sizeDelta);  // получаем размер  типа Vector2

                        rectTransfrom.sizeDelta = new Vector2(100, height * procs[i]);
                    }
                }
                else { }
            }
        }
        else
        {
            if (sk2.color == Color.green)
            {
                procs[0] = 11;
                procs[1] = 15;
                procs[2] = 17;
                procs[3] = 9;
                for (int i = 0; i < procs.Length; i++)
                {
                    rectTransfrom = subjects[i].GetComponent<RectTransform>();

                    Debug.Log(rectTransfrom.sizeDelta);  // получаем размер  типа Vector2

                    rectTransfrom.sizeDelta = new Vector2(100, height * procs[i]);
                }
                if (sk3.color == Color.green)
                {
                    procs[0] = 15;
                    procs[1] = 25;
                    procs[2] = 30;
                    procs[3] = 27;
                    for (int i = 0; i < procs.Length; i++)
                    {
                        rectTransfrom = subjects[i].GetComponent<RectTransform>();

                        Debug.Log(rectTransfrom.sizeDelta);  // получаем размер  типа Vector2

                        rectTransfrom.sizeDelta = new Vector2(100, height * procs[i]);
                    }
                }
                else
                {
                }
            }
            else
            {
                if (sk3.color == Color.green)
                {
                    procs[0] = 10;
                    procs[1] = 25;
                    procs[2] = 20;
                    procs[3] = 21;
                    for (int i = 0; i < procs.Length; i++)
                    {
                        rectTransfrom = subjects[i].GetComponent<RectTransform>();

                        Debug.Log(rectTransfrom.sizeDelta);  // получаем размер  типа Vector2

                        rectTransfrom.sizeDelta = new Vector2(100, height * procs[i]);
                    }
                }
                else
                {
                }
            }
        }
    }
}
