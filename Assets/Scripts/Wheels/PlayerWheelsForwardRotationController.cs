using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;

namespace TopDownShooter.WheelControls
{
    public class PlayerWheelsForwardRotationController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;

        [SerializeField] private Transform _wheelFLeft;
        [SerializeField] private Transform _wheelFRight;
        [SerializeField] private Transform _wheelBLeft;
        [SerializeField] private Transform _wheelBRight;

        [SerializeField] private PlayerWheelsForwardRotationSettings _wheelsForwardRotationSettings;

        private void Update()
        {
            if (_inputData.Vertical != 0)
            {
                _wheelFLeft.Rotate(_inputData.Vertical * _wheelsForwardRotationSettings.HorizontalSpeed, 0, 0, Space.Self);
                _wheelFRight.Rotate(_inputData.Vertical * _wheelsForwardRotationSettings.HorizontalSpeed, 0, 0, Space.Self);
                _wheelBLeft.Rotate(_inputData.Vertical * _wheelsForwardRotationSettings.HorizontalSpeed, 0, 0, Space.Self);
                _wheelBRight.Rotate(_inputData.Vertical * _wheelsForwardRotationSettings.HorizontalSpeed, 0, 0, Space.Self);
            }
        }
    }
}