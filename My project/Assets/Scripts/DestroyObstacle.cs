using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : BaseObstacle
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    internal override void OnHit()
    {
        base.OnHit();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
