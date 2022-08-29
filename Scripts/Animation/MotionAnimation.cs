using System;
using UnityEngine;

namespace Flashlight.Scripts.Animation
{
    public class MotionAnimation : MonoBehaviour
    {
        [SerializeField] private Transform _animationObject;
        [SerializeField] private float _speedAnimation;
        [SerializeField] private float _speedLerp;

        [SerializeField] private AnimationCurve _x;
        [SerializeField] private AnimationCurve _y;
        [SerializeField] private AnimationCurve _z;

        private float _timer;

        private void Update()
        {
            UpdateTimer();
            Animate();
        }

        private void UpdateTimer()
        {
            _timer += Time.deltaTime;

            if(_timer > 1)
                _timer = 0;
        }

        private void Animate()
        {
            var target = new Vector3(_x.Evaluate(_timer), _y.Evaluate(_timer), _z.Evaluate(_timer)) * _speedAnimation;

            _animationObject.localRotation = LerpRotationAnimation(target);
            //_animationObject.localPosition = LerpPositionAnimation(target);
        }

        private Quaternion LerpRotationAnimation(Vector3 target)
        {
            return Quaternion.Lerp(_animationObject.localRotation, Quaternion.Euler(target), _speedLerp * Time.deltaTime);
        }

        private Vector3 LerpPositionAnimation(Vector2 target)
        {
            return Vector3.Lerp(_animationObject.localPosition, target, _speedLerp * Time.deltaTime);
        }
    }
}
