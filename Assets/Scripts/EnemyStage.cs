using UnityEngine;

[System.Serializable]
public class EnemyStage
{
    public float startDistance;
    public float endDistance;
    [Range(0f, 1f)] public float type1Chance;
    [Range(0f, 1f)] public float type2Chance;
    [Range(0f, 1f)] public float type3Chance;
}
