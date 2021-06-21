
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

    private void Start()
    {
        turretToBuild = standartTurretPreFab;
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
