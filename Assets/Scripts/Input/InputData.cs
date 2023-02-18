using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    [CreateAssetMenu(menuName = "TopDownShooter/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;

        [Header("Axis Base Control")]
        [SerializeField] private bool _axisActive;
        [SerializeField] private string _axisNameHorizontal;
        [SerializeField] private string _axisNameVertical;

        [Header("Key Base Control")]
        [SerializeField] private bool _keyBaseHorizontalActive;
        [SerializeField] private KeyCode _positiveHorizontalKeyCode;
        [SerializeField] private KeyCode _negativeHorizontalKeyCode;
        [SerializeField] private bool _keyBaseVerticalActive;
        [SerializeField] private KeyCode _positiveVerticalKeyCode;
        [SerializeField] private KeyCode _negativeVerticalKeyCode;
        [SerializeField] private float _increaseAmount = 0.015f;

        public void ProcessInput()
        {
            if (_axisActive)
            {
                Horizontal = Input.GetAxis(_axisNameHorizontal);
                Vertical = Input.GetAxis(_axisNameVertical);
            }
            else
            {
                if (_keyBaseHorizontalActive)
                {
                    KeyBaseAxisControl(ref Horizontal, _positiveHorizontalKeyCode, _negativeHorizontalKeyCode);
                }
                if (_keyBaseVerticalActive)
                {
                    KeyBaseAxisControl(ref Vertical, _positiveVerticalKeyCode, _negativeVerticalKeyCode);
                }
            }
        }

        public void KeyBaseAxisControl(ref float value, KeyCode positive, KeyCode negative)
        {
            bool positiveActive = Input.GetKey(positive);
            bool negativeActive = Input.GetKey(negative);
            if (positiveActive)
            {
                value += _increaseAmount;
            }else if (negativeActive)
            {
                value -= _increaseAmount;
            }
            else
            {
                value = 0;
            }
            value = Mathf.Clamp(value, -1, 1);
        }
    }
}