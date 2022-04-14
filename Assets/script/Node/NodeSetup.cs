using UnityEngine;
using UnityEngine.UI;

public class NodeSetup : MonoBehaviour
{
    public static NodeSetup nodeSetup;
    [SerializeField] GameObject createTreeButton;
    [SerializeField] GameObject createChidNodeButton;
    [SerializeField] GameObject AddChildOrParentAsk;
    [SerializeField] GameObject NodeHolder;

    [Space(20)]
    public Node CurrentNode;
    [SerializeField] GameObject newChild;

    [Space(20)]
    [SerializeField] GameObject NodePrefab;
    [SerializeField] GameObject NodeChildHolderPrefab;
    [SerializeField] GameObject NodeChildHolder;
    [SerializeField] GameObject mainParent;



    void Start()
    {
        if (nodeSetup == null) { nodeSetup = this; } else { Destroy(this); }
        ChidNodeButtonValidation();
        createTreeButton.GetComponent<Button>().onClick.AddListener(() => { OnTreeButtonClick(); });
        createChidNodeButton.GetComponent<Button>().onClick.AddListener(() => { OnChildButtonClick(); });
    }
    void OnChildButtonClick()
    {
        AddChildOrParentAsk.SetActive(false);
        newChild = Instantiate(NodePrefab, NodeHolder.transform) as GameObject;

        if (CurrentNode.GetComponent<Node>().NodeChildHolder == null)
        {
            CurrentNode.GetComponent<Node>().NodeChildHolder = Instantiate(NodeChildHolderPrefab, NodeHolder.transform) as GameObject;
            CurrentNode.GetComponent<Node>().NodeChildHolder.SetActive(true);
        }
        newChild.transform.SetParent(CurrentNode.GetComponent<Node>().NodeChildHolder.transform);

        newChild.SetActive(true);
        newChild.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
        CurrentNode.GetComponent<Node>().Childs.Add(newChild.GetComponent<Node>());
        newChild.GetComponent<Node>().Parent = CurrentNode;

        postionSetup(CurrentNode);

    }

    void postionSetup(Node currentNode)
    {
        Vector2 postion = mainParent.GetComponent<RectTransform>().position;
    }
    void OnTreeButtonClick()
    {
        AddChildOrParentAsk.SetActive(false);
        mainParent = Instantiate(NodePrefab, NodeHolder.transform) as GameObject;
        mainParent.SetActive(true);
        mainParent.name = "mainNode";

    }

    void ChidNodeButtonValidation()
    {
        if (mainParent == null)
        {
            createTreeButton.GetComponent<Button>().interactable = true;
            createChidNodeButton.GetComponent<Button>().interactable = false;
        }
        else
        {
            createChidNodeButton.GetComponent<Button>().interactable = true;
            createTreeButton.GetComponent<Button>().interactable = false;
        }
    }


    private void OnEnable()
    {
        ChidNodeButtonValidation();
    }
    private void OnDisable()
    {
        ChidNodeButtonValidation();
    }
   
    
}
