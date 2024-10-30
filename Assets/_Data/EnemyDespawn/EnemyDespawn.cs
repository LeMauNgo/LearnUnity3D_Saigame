using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDespawn : Despawn<EnemyCtrl> 
{
    // Start is called before the first frame update
    void Start()
    {
        this.isDespawnByTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
