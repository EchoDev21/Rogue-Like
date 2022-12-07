using System;
using DataTypes;
using UnityEngine;
using Runtime_Sets;

namespace Player
{
        public class MoveController : MonoBehaviour
        {
                [Header("Movement Values")] [SerializeField]
                private Vector2Ref moveDirection;

                [SerializeField] private FloatRef moveSpeed;

                [Header("References")] private Rigidbody2D _rigidbody;
                private Vector2 _refVector = Vector2.zero;

                private void Awake()
                {
                        _rigidbody = GetComponent<Rigidbody2D>();
                }

                private void FixedUpdate()
                {
                        var oldVelocity = _rigidbody.velocity;
                        var newVelocity = moveDirection.Value * moveSpeed.Value;

                        _rigidbody.velocity = Vector2.SmoothDamp(
                                oldVelocity,
                                newVelocity,
                                ref _refVector,
                                Time.deltaTime * 5f);
                }
        }
}