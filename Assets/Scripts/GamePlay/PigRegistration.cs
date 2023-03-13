using UnityEngine;

public class PigRegistration : MonoBehaviour
{
    void Start() => PigLevelPool.Instance?.Add(transform);
    void OnDestroy() => PigLevelPool.Instance?.Remove(transform);
}