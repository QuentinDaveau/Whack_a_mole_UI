using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonDrop : MonoBehaviour
{
    public Dropdown dropDown;

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
        SwitchSelected(false);
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
        }
        else
        {
            GetComponent<Button>().interactable = false;
            // inputField.ActivateInputField();
        }
    }
}
