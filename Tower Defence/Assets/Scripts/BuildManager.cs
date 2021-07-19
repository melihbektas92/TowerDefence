
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if (instance!=null)
        {
            Debug.LogError("More than once BuildManager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standartTurretPreFab;
    public GameObject missileLauncherPreFab;

    public TurretBluePrint turretToBuild;
    
    public bool CanBuild { get { return turretToBuild != null; } }

    public void BuildTurretOn (Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enough money");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        Debug.Log("Turret build!");
    }

    public void SelectTurretToBuild (TurretBluePrint turret)
    {
        turretToBuild = turret;
    }
}
