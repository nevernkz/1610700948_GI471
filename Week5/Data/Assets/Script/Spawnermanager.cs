using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Spawnermanager : MonoBehaviour
{
    public static Spawnermanager instance;
    public List<Spawner> spawnerList = new List<Spawner>();
    public void Awake()
    {
        instance = this;
        Init();
    }
    private void Init()
    {
        Spawner[] spawnerArr = FindObjectsOfType<Spawner>();
        spawnerList = spawnerArr.ToList<Spawner>();
    }
    
    public void Spawn()
    {

        foreach (Spawner spawner in spawnerList)
        {
            spawner.Spawn();
        }
    }
}
