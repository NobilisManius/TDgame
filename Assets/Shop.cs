using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandartTurret()
    {
        buildManager.SetTurretToBuild(buildManager.standartTurretPrefab);
    }
    public void PurchaseMissleTurret()
    {
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
    public void PurchaseSomeTurret()
    {
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
    public void CancelPurchase()
    {
        buildManager.SetTurretToBuild(null);
    }



}
