using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gametest : MonoBehaviour
{
    public Spawnermanager spawnermanager;
    public EventManager eventManager;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            EventManager.instance.TriggerEvent("Spawn");
        }
    }
}
