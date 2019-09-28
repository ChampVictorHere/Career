using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuAnim : MonoBehaviour
{
    // Start is called before the first frame update

    public bool flag;
    public GameObject menu;
    public Transform[] points;
    public Vector3 p1, p2;

    public void Start()
    {
        Vector3 p1 = new Vector3(points[0].position.x, points[0].position.y, points[0].position.z);
        Vector3 p2 = new Vector3(points[1].position.x, points[1].position.y, points[1].position.z);
    }

    public void menu_activ()
    {
        Vector3 p1 = new Vector3(points[0].position.x, points[0].position.y, points[0].position.z);
        Vector3 p2 = new Vector3(points[1].position.x, points[1].position.y, points[1].position.z);

        if (flag)
        {
            transform.DOMove(p1, 0.3f);
        }
        else
        {
            transform.DOMove(p2, 0.3f);
        }

        flag = !flag;
    }
}
