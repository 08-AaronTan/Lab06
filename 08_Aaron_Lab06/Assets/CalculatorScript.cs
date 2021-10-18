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
    public Toggle toggleRM;
    public Toggle toggleEUR;
    public Toggle toggleKoreanWon;
    public Toggle toggleTaiwanDollar;

    public InputField Amount;
    public InputField Value;
    public InputField inputCovertedAmount;

    public Text debugText;

    private float SGDUSD_rate = 0.74f;
    private float SGDJPY_rate = 82.79f;
    private float RM = 3.08f;
    private float EUR = 0.63f;
    private float KoreanWon = 881.54f;
    private float TaiwanDollar = 20.73f;

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
            toggleRM.isOn = false;
            toggleEUR.isOn = false;
            toggleKoreanWon.isOn = false;
            toggleTaiwanDollar.isOn = false;
        }

        else if (toggleJapaneseYen.isOn)
        {
            storeNumber = storeNumber * SGDJPY_rate;
            toggleUSDollar.isOn = false;
            toggleRM.isOn = false;
            toggleEUR.isOn = false;
            toggleKoreanWon.isOn = false;
            toggleTaiwanDollar.isOn = false;
        }

        else if (toggleRM.isOn)
        {
            storeNumber = storeNumber * RM;
            toggleUSDollar.isOn = false;
            toggleJapaneseYen.isOn = false;
            toggleEUR.isOn = false;
            toggleKoreanWon.isOn = false;
            toggleTaiwanDollar.isOn = false;
        }
        else if (toggleEUR.isOn)
        {
            storeNumber = storeNumber * EUR;
            toggleUSDollar.isOn = false;
            toggleJapaneseYen.isOn = false;
            toggleRM.isOn = false;
            toggleKoreanWon.isOn = false;
            toggleTaiwanDollar.isOn = false;
        }
        else if (toggleKoreanWon.isOn)
        {
            storeNumber = storeNumber * KoreanWon;
            toggleUSDollar.isOn = false;
            toggleJapaneseYen.isOn = false;
            toggleRM.isOn = false;
            toggleEUR.isOn = false;
            toggleTaiwanDollar.isOn = false;
        }

        else if (toggleTaiwanDollar.isOn)
        {
            storeNumber = storeNumber * TaiwanDollar;
            toggleUSDollar.isOn = false;
            toggleJapaneseYen.isOn = false;
            toggleRM.isOn = false;
            toggleEUR.isOn = false;
            toggleKoreanWon.isOn = false;

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
        toggleRM.isOn = false;
        toggleEUR.isOn = false;
        toggleKoreanWon.isOn = false;
        toggleTaiwanDollar.isOn = false;
        print("");
    }
}
