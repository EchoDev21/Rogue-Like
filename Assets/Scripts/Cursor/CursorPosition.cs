using DataTypes;
using UnityEngine;

namespace Cursor
{
        public class CursorPosition : MonoBehaviour
        {
                [SerializeField] private Vector2Ref mousePos;

                private void Start()
                {
                        UnityEngine.Cursor.visible = false;
                }

                private void Update()
                {
                        transform.position = mousePos.Value;
                }
        }
}