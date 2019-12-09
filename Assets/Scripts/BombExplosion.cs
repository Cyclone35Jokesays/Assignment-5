using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    public static bool disabled = false;

    void Update()
    {
      
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bomb" )
        {
            Destroy(col.gameObject);
            
        }
    }
}
