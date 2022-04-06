using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL;
    }

    private void OnDisable()
    {
        if(pool != null)
        {
            pool.ReturnObjects(this.gameObject); //return this object to pool
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
