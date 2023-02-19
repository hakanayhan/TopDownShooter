using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.Shooting;

namespace TopDownShooter.Camera

{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private Transform _cameraTransform;
        public ShootingManager _shootingManager;
        private void Update()
        {
            CameraRotationFollow();
            CameraMovementFollow();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Try Shoot");
                _shootingManager.Shoot(_cameraTransform.position, _cameraTransform.forward);
            }
        }

        private void CameraRotationFollow()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation, Quaternion.LookRotation(_targetTransform.forward), Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }

        private void CameraMovementFollow()
        {
            Vector3 offset = (_cameraTransform.right * _cameraSettings.PositionOffset.x) + (_cameraTransform.up * _cameraSettings.PositionOffset.y) + (_cameraTransform.forward * _cameraSettings.PositionOffset.z);
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, _targetTransform.position + offset, Time.deltaTime * _cameraSettings.PositionLerp);
        }
    }
}