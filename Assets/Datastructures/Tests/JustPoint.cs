using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class JustPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, Vector3.one / 10);
    }
}
