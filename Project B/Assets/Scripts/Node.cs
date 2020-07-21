using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;
    public Vector3 positionOffest;


    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>(); // Caches the Renderer on game start rather than every time it's hovered.
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if( turret != null )
        {
            Debug.Log("Turret already on this spot");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffest, transform.rotation);
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

     void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
