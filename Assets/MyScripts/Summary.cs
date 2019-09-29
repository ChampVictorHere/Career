using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Summary : MonoBehaviour
{
    public InputField input1, input2, input3, input4, input5, input6, input7;
    public Text sumText1, sumText2, sumText3, sumText4, sumText5, sumText6, sumText7;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClickEnd(){
        sumText1.text = input1.text;
        sumText2.text = input2.text;
        sumText3.text = input3.text;
        sumText4.text = input4.text;
        sumText5.text = input5.text;
        sumText6.text = input6.text;
        sumText7.text = input7.text;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
