using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interview : MonoBehaviour
{
    int i_p = 0;
    public Text ticketText; 
    public GameObject gameObject1, gameObject2, gameObject3, gameObject4, gameObject5, gameObject6, gameObject7;
    public GameObject gameObjectT1, gameObjectT2, gameObjectT3, gameObjectT4, gameObjectT5, gameObjectT6, gameObjectT7, gameObjectT8;

    // Start is called before the first frame update
    void Start()
    {
        if (ticketText.text != "Ждем вас на собеседовании!") { i_p = 1; gameObject1.SetActive(true);
            gameObjectT1.SetActive(true);
        }
        else { gameObject1.SetActive(false);
            gameObjectT1.SetActive(false);
        }
        //i_p = 1;
        gameObject2.SetActive(false);
        gameObject3.SetActive(false);
        gameObject4.SetActive(false);
        gameObject5.SetActive(false);
        gameObject6.SetActive(false);
        gameObject7.SetActive(false);
        gameObjectT2.SetActive(false);
        gameObjectT3.SetActive(false);
        gameObjectT4.SetActive(false);
        gameObjectT5.SetActive(false);
        gameObjectT6.SetActive(false);
        gameObjectT7.SetActive(false);
        gameObjectT8.SetActive(false);
    }
    public void ClickAnswear() {
        switch (i_p)
        {
            case 1:
                gameObject2.SetActive(true);
                gameObjectT2.SetActive(true);
                i_p++;
                break;
            case 2:
                gameObject3.SetActive(true);
                gameObjectT3.SetActive(true);
                i_p++;
                break;
            case 3:
                gameObject4.SetActive(true);
                gameObjectT4.SetActive(true);
                i_p++;
                break;
            case 4:
                gameObject5.SetActive(true);
                gameObjectT5.SetActive(true);
                i_p++;
                break;
            case 5:
                gameObject6.SetActive(true);
                gameObjectT6.SetActive(true);
                i_p++;
                break;
            case 6:
                gameObject7.SetActive(true);
                gameObjectT7.SetActive(true);
                i_p++;
                break;
            default:
                gameObjectT8.SetActive(true);
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
