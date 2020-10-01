using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject zombie;
    
    // Start is called before the first frame update

    private void OnEnable()
    {
        EventManager.instance.StartListening("Spawn", Spawn);
    }
    private void OnDisable()
    {
        EventManager.instance.StopListening("Spawn", Spawn);
    }
    public void Spawn()
    {
        Instantiate(zombie,this.transform.position,this.transform.rotation);


    }
    

}
