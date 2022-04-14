using System.Collections;
using System.Collections.Generic;
using Michsky.UI.ModernUIPack;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour , IPointerDownHandler
{
    [SerializeField] GameObject PopupChildOrParent;
    [SerializeField] GameObject AddChildButton;
    [SerializeField]public GameObject NodeChildHolder;

    [Space(15)]
    [SerializeField]public Node Parent;
    [SerializeField]public List<Node> Childs;

    private void Start()
    {
        AddChildButton.GetComponent<ButtonManagerBasicIcon>().clickEvent.AddListener(() => { OnChildAddClick(); });
    }
    void OnChildAddClick()
    {
        PopupChildOrParent.SetActive(true);
        NodeSetup.nodeSetup.CurrentNode = this;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        CameraSetup.mycamera.Target = this.gameObject;

    }
}
