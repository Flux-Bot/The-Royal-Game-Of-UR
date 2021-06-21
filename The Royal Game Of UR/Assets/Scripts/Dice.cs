using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dice : MonoBehaviour
{
    public Text Dice_UIText;
    private int Dice1;
    private int Dice2;
    private int Dice3;
    private int Dice4;
    private string Output;

    void Start()
    {

    }

    void OnMouseUp() {
        Dice1 = UnityEngine.Random.Range(0,2);
        Dice2 = UnityEngine.Random.Range(0,2);
        Dice3 = UnityEngine.Random.Range(0,2);
        Dice4 = UnityEngine.Random.Range(0,2);
        int Sum = Dice1 + Dice2 + Dice3 + Dice4;
        Output = Sum.ToString();
        Dice_UIText.text = Output;
        
    }
}
