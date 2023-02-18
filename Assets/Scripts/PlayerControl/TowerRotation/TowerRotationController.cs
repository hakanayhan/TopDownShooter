using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;

namespace TopDownShooter.PlayerControls
{
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] private InputData _rotationInputData;
        [SerializeField] private Transform _towerTransform;
        [SerializeField] private TowerRotationSettings _TowerRotationSettings;

        private void Update()
        {
            _towerTransform.Rotate(0, _rotationInputData.Horizontal * _TowerRotationSettings.TowerRotationSpeed, 0, Space.Self);
        }
    }
}