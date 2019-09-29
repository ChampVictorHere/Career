using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAnim : MonoBehaviour
{
    // Start is called before the first frame update

    public bool flag;
    public GameObject menu, clic_back;
    public Transform[] points;
    public Vector3 p1, p2;
    public Image menu_main;
    public Color c1, c2;

    public void Start()
    {
        Vector3 p1 = new Vector3(points[0].position.x, points[0].position.y, points[0].position.z);
        Vector3 p2 = new Vector3(points[1].position.x, points[1].position.y, points[1].position.z);

    }

    public void menu_activ()
    {
        Vector3 p1 = new Vector3(points[0].position.x, points[0].position.y, points[0].position.z);
        Vector3 p2 = new Vector3(points[1].position.x, points[1].position.y, points[1].position.z);
        Color c1 = new Color(0.188f, 0.070f, 0.305f, 1f);
        Color c2 = new Color(0.368f, 0.137f, 0.615f, 1f);

        if (flag)
        {
            Sequence mySequence = DOTween.Sequence();
            mySequence.Append(transform.DOMove(p1, 0.3f));
            mySequence.PrependCallback(change);
            menu_main.color = c1;
        }
        else
        {
            Sequence mySequence = DOTween.Sequence();
            mySequence.Append(transform.DOMove(p2, 0.3f));
            mySequence.PrependCallback(change);
            menu_main.color = c2;
        }

        flag = !flag;
    }

    public void change()
    {
        if (flag)
        {
            menu.GetComponent<Image>().color =  new Color(0.368f, 0.137f, 0.615f, 0f);
            clic_back.SetActive(true);
        }
        else
        {
            menu.GetComponent<Image>().color = new Color(0.368f, 0.137f, 0.615f, 1f);
            clic_back.SetActive(false);
        }
    }

}
