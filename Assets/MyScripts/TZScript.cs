using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TZScript : MonoBehaviour
{
    GameObject g;
    public InputField input1;
    public InputField input2;
    public InputField input3;
    public InputField input4;
    public InputField input5;
    public Image skill1;
    public Image skill2;
    public Image skill3;
    public Text endText;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnClick()
    {
        if(input1.text == "using System;" && input3.text == "age = person.age;" && input5.text == "Наследование")
        {
            skill1.color = Color.green;
            if (input2.text == "Command"||input2.text == "Команда")
            {
                skill2.color = Color.green;
                if (input4.text == "gObject.SetActive(false);" || input4.text == "Команда")
                {
                    endText.text = "Ждем вас на собеседовании!";
                    skill3.color = Color.green;
                }
                else
                {

                }
            }
            else
            {

            }
        }
        else
        {
            if (input2.text == "Command" || input2.text == "Команда")
            {
                skill2.color = Color.green;
                if (input4.text == "gObject.SetActive(false);" || input4.text == "Команда")
                {
                    skill3.color = Color.green;
                }
                else
                {

                }
            }
            else
            {
                if (input4.text == "gObject.SetActive(false);" || input4.text == "Команда")
                {
                    skill3.color = Color.green;
                }
                else
                {

                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
