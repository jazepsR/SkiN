using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObstacle : MonoBehaviour
{
    public string obstacleName;
    // Start is called before the first frame update
    void OnCollisionEnter()
    {
        OnHit();
    }

    internal virtual void OnHit()
    {
        GameEvents.CallTakeDamage();
        Debug.Log("obstacle was hit!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
