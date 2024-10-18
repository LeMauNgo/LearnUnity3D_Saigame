using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSpawner : MySingleton<EffectSpawner>
{
    [SerializeField] protected GameObject bullet;
    public virtual void SpawnBullet(Vector3 position, Quaternion rotation)
    {
        GameObject newBullet = Instantiate(this.bullet, position, rotation);
    }
}
