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
                RotateWheelForward(_inputData.Vertical * _wheelsForwardRotationSettings.VerticalSpeed);
            }
        }

        private void RotateWheelForward(float x)
        {
            _wheelFLeft.Rotate(x, 0, 0, Space.Self);
            _wheelFRight.Rotate(x, 0, 0, Space.Self);
            _wheelBLeft.Rotate(x, 0, 0, Space.Self);
            _wheelBRight.Rotate(x, 0, 0, Space.Self);
        }
    }
}