using UnityEngine;
 
public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    public NodeUI nodeUI;

    private Node selectedNode;


    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one build manager in the scene!");
            return;
        }

        instance = this;
    } 

    public GameObject buildEffect;

    private TurretBlueprint turretToBuild;

    public bool CanBuild
    {
        get
        {
            return turretToBuild != null;
        }
    }

    public bool HasMoney
    {
        get
        {
            return PlayerStats.Money >= turretToBuild.cost;
        }
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;

        DeselectNode();
    }

    public void SelectNode(Node node)
    {
        if (selectedNode == node)
        {
            DeselectNode();
            return;
        }

        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node); 
    }

    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }

    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }
}
