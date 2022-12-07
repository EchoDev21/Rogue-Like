using System;
using UnityEngine;

namespace DataTypes
{
        [CreateAssetMenu(fileName = "New String", menuName = "Data Types/String")]
        public class StringVar : ScriptableObject
        {
                public string value;
        }

        [Serializable]
        public class StringRef
        {
                public StringVar var;
                public bool canSet;

                public string Value
                {
                        get => var.value;
                        set
                        {
                                if (canSet)
                                        var.value = value;
                        }
                }
        }
}