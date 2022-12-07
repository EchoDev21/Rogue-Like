using System;
using DataTypes;
using UnityEngine;

namespace Player
{
        [RequireComponent(typeof(Animator))]
        public class AnimationController : MonoBehaviour
        {
                private Animator _playerAnimator;


                private void Awake()
                {
                        _playerAnimator ??= GetComponent<Animator>();
                }

                [SerializeField] private BoolRef isMoving;

                private void Update()
                {
                        _playerAnimator.SetBool("isMoving", isMoving.Value);
                }
        }
}