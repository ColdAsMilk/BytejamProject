﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public GameObject Tower { get; private set; }
    public void PickTower(GameObject tower)
    {
        this.Tower = tower;
        Debug.Log("PIcked tower" + tower.name);
    }
}
