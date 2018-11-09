﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;

    public BuildManager build

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if()

        if (turret != null)
        {
            Debug.Log("Can't Build There! - TODO: Display This On Screen");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject) Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation); 
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
