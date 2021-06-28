using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchasedStandartTurret()
    {
        Debug.Log("Standart Turret Selected");
        buildManager.SetTurretToBuild(buildManager.standartTurretPreFab);
    }
    public void MissileLauncherTurret()
    {
        Debug.Log("Missile Launcher Selected");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPreFab);

    }
}
