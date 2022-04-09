using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Component : MonoBehaviour
{
    [SerializeField]protected string name;

    [Space(5)]
    [SerializeField] protected Button addButton;
    [SerializeField] protected Button removeButton;
    [SerializeField] protected TMP_InputField InputFieldName;
    [SerializeField] bool isReadytoAdd;
    [SerializeField] bool isReadytoRemove;

    public bool ValidateAdd()
    {
        if (InputFieldName == null) return false;
        if (InputFieldName.text.Contains("") == true ){ return false; }
        if (InputFieldName.text.Contains("") == false)
        {
            name = InputFieldName.text;
            return true;
        }
        return false;
    }
    public bool ValidateRemove()
    {
        return false;
    }

    private void OnValidate()
    {
        isReadytoAdd = ValidateAdd();
        isReadytoRemove = ValidateRemove();
    }

    [SerializeField]public Component(string name)    {        this.name = name;    }
    [SerializeField]public  void Add(Component c){ }
    [SerializeField]public  void remove(Component c){ }
    [SerializeField]public  void Display(int depth){ }

    
}
