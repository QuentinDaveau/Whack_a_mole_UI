using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonTextController : MonoBehaviour
{
    public GameObject editText;
    public GameObject infoText;
    public GameObject inputField;
    public int defaultValue = -1;
    public bool swapInfoTextOrder = false;

    private int inputValue = -1;
    private string defaultinfoText = "";
    private bool edit = false;
    
    void Start()
    {
        defaultinfoText = infoText.GetComponent<Text>().text;
        
        if (defaultValue != -1 && defaultValue <= 999)
        {
            inputField.GetComponent<InputField>().text = defaultValue.ToString();
            UpdateinputValue();
        }
        FocusInfo();
    }

    public void OnMouseClick()
    {
        GetComponent<Button>().interactable = false;
        FocusInput();
        inputField.GetComponent<InputField>().ActivateInputField();
    }

    public void OnMouseEnter()
    {
        FocusEdit();
    }

    public void OnMouseLeave()
    {
        if (!edit)
        {
            FocusInfo();
        }
    }

    public void OnInputEndEdit()
    {
        edit = false;
        UpdateinputValue();
        FocusInfo();
        GetComponent<Button>().interactable = true;
    }

    private void UpdateinputValue()
    {
        var inputText = inputField.GetComponent<InputField>().text;
        if (inputText != "")
        {
            var tempValue = int.Parse(inputField.GetComponent<InputField>().text);
            
            if (tempValue < 0)
            {
                return;
            }

            inputValue = tempValue;

            if (!swapInfoTextOrder)
            {
                infoText.GetComponent<Text>().text = defaultinfoText + inputValue.ToString();
            }
            else
            {
                infoText.GetComponent<Text>().text = inputValue.ToString() + defaultinfoText;
            }
        }
    }

    private void FocusEdit()
    {
        inputField.SetActive(false);
        editText.SetActive(true);
        infoText.SetActive(false);
    }

    private void FocusInfo()
    {
        inputField.SetActive(false);
        editText.SetActive(false);
        infoText.SetActive(true);
    }

    private void FocusInput()
    {
        edit = true;
        inputField.SetActive(true);
        editText.SetActive(false);
        infoText.SetActive(false);
    }
}
