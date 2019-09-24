using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonInput : MonoBehaviour
{
    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FocusInputField()
    {
        Debug.Log("ee");
        SwitchSelected(false);
        // inputField.Select();
    }

    public void SwitchSelected(bool it = true)
    {
        if (it)
        {
            if (!EventSystem.current.alreadySelecting)
            {
                EventSystem.current.SetSelectedGameObject(null);
            }
            
            GetComponent<Button>().interactable = true;
            
            // inputField.interactable = false;
            // inputField.DeactivateInputField();
            
        }
        else
        {
            GetComponent<Button>().interactable = false;
            // inputField.interactable = true;
            inputField.ActivateInputField();
        }
    }
}
