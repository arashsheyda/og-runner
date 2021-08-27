using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Random olarak oluşacak değer aralığı (Inspector'da görüntülenmesi için oluşturuldu)
/// </summary>
[System.Serializable]
public struct RandomTwoPoint
{
    [Tooltip("Random olarak oluşacak en küçük değer")]
    [SerializeField]private float minValue;
    [Tooltip("Random olarak oluşacak en büyük değer")]
    [SerializeField]private float maxValue;
    /// <summary>
    /// Random değeri al
    /// </summary>
    public float GetRandomValue
    {
        get
        {
            return Random.Range(minValue,maxValue);
        }
    }
}