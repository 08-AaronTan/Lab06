using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    Toggle toggleUSDollar;
    Toggle toggleJapaneseYen;

    public Text inputConvertAmount;
    public Text inputAmount;

    private double SGDUSD_rate;
    private double SGDJPY_rate;

    // Start is called before the first frame update
    void Start()
    {
        toggleUSDollar.isOn = false;
        toggleJapaneseYen.isOn = false;        SGDUSD_rate = 0.74;
        SGDJPY_rate = 82.79;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConvertBtn()
    {
        if(toggleUSDollar.isOn == true && toggleJapaneseYen.isOn == false)
        {
            float amount = float.Parse(inputAmount.text);
            inputConvertAmount.text = "$" + (amount * SGDUSD_rate);
        }
        if (toggleJapaneseYen.isOn == true && toggleUSDollar.isOn == true)
        {
            float amount = float.Parse(inputAmount.text);
            inputConvertAmount.text = "$" + (amount * SGDJPY_rate);
        }
    }
}
