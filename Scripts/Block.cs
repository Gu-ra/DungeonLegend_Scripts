using System;
using UnityEngine;

public class Block : MonoBehaviour, IDamagable
{
    //破壊可能なブロック
    public void AddDamage(float damage)
    {
        if (damage >= 100f)
        {
            Object.Destroy(base.gameObject);
        }
    }
}