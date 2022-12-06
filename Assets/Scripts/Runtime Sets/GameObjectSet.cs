using UnityEngine;

namespace Runtime_Sets
{
    [CreateAssetMenu(fileName = "New GameObject Set",menuName = "Runtime Sets/GameObject Set")]
    public class GameObjectSet : RuntimeSet<GameObject>
    {
        public override GameObject FindItemInSet(GameObject item)
        {
            GameObject foundItem = null;
            for (var i = this.runtimeSet.Count - 1; i >= 0; i--)
            {
                foundItem = runtimeSet[i] == item ? runtimeSet[i] : null;
            }

            return foundItem;
        }
    }
}
