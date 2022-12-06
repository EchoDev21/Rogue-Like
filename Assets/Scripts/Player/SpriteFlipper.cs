using System;
using DataTypes;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class SpriteFlipper : MonoBehaviour
    {
        [SerializeField] private Vector2Ref mousePosition;
        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer ??= GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            _spriteRenderer.flipX = mousePosition.Value.x < transform.position.x;
        }
    }
}
