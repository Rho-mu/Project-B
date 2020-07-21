using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private GameObject turretToBuild;
    public GameObject standardTurretPrefab;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("BuildManager already exists!");
        }
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        turretToBuild = standardTurretPrefab; // Defaults turretToBuild to the standard turret.
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
