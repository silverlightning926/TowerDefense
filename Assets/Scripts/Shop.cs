using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret ()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseAnotherTurret ()
    {
        Debug.Log("Another Standard Turret Selected");
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
}
