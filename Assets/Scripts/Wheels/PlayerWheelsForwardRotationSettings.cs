using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TopDownShooter/Wheels/Wheels Forward Rotation Settings")]
public class PlayerWheelsForwardRotationSettings : ScriptableObject
{
    [SerializeField] public float HorizontalSpeed = 2f;
}
