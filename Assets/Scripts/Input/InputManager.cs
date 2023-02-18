using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData[] _InputDataArray;

        private void Update()
        {
            for (int i = 0; i < _InputDataArray.Length; i++)
            {
                _InputDataArray[i].ProcessInput();
            }
        }
    }
}