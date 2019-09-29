using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webPages : MonoBehaviour
{
    public string url;
    public string url2;
    public string url3;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OpenUrl()
    {
        Application.OpenURL(url);
    }
    public void OpenUrl2()
    {
        Application.OpenURL(url2);
    }
    public void OpenUrl3()
    {
        Application.OpenURL(url3);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
