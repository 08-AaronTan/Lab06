using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public string storeText;
    public float storeNumber;
    public GameObject inputText;

    public Toggle toggleUSDollar;
    public Toggle toggleJapaneseYen;

    public InputField Amount;
    public InputField Value;
    public InputField inputCovertedAmount;

    public Text debugText;

    private float SGDUSD_rate = 0.74f;
    private float SGDJPY_rate = 82.79f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ConvertBtn()
    {
        try
        {
            storeText = inputText.GetComponent<Text>().text;
            storeNumber = float.Parse(storeText);
        }

        catch
        {
            debugText.text = "Please enter a vaild amount";
        }

        if(toggleUSDollar.isOn)
        {
            storeNumber = storeNumber * SGDUSD_rate;
            toggleJapaneseYen.isOn = false;
        }

        else if (toggleJapaneseYen.isOn)
        {
            storeNumber = storeNumber * SGDJPY_rate;
            toggleUSDollar.isOn = false;
        }

        else
        {
            debugText.text = "Please only select 1 currency.";
        }

        inputCovertedAmount.text = "$" + storeNumber.ToString();

    }
    public void Clearbtn()
    {
        storeNumber = 0;
        Amount.text = "";
        Value.text = "";

        toggleUSDollar.isOn = false;
        toggleJapaneseYen.isOn = false;

    }
}
