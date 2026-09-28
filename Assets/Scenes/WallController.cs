using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;

    void Update()
    {
        if (target1 == null &&
            target2 == null &&
            target3 == null &&
            target4 == null)
        {
            Destroy(gameObject);
        }
    }
}
