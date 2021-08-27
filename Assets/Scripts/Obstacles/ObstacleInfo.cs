using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Mermi ile ilgili değerler set ve get eder.
/// </summary>
[System.Serializable]
public struct ObstacleInfo 
{
    [Tooltip("Mermi'nin Hızı")]
    public float speed;
    [Tooltip("Hareket etmesini istediğiniz yöne 1 değerini verin.")]
    public Vector3 direction;


    [Header("Create Time Range")]
    public RandomTwoPoint waitTimeFirstShot;
    public RandomTwoPoint randomTime;
    /// <summary>
    /// Speed ve Direction çarpımıyla hız ve yön çarpımı ile güç belirlenir.
    /// </summary>
    public Vector3 force
    {
        get
        {
            return direction * speed;
        }
    }

}
