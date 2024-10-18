using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletMoving : MyBehaviour
{
    [SerializeField] protected float speed;
    private void Update()
    {
        this.Moving();
    }
    protected virtual void Moving()
    {
        transform.parent.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
