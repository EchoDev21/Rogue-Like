using UnityEngine;

namespace Runtime_Sets.Components
{
    public class GameObjectSetItem : MonoBehaviour
    {
        [SerializeField] private GameObjectSet set;

        [SerializeField] private bool addItemToSetOnEnable;
        [SerializeField] private bool removeItemFromSetOnDisable;

        private void OnEnable()
        {
            if (addItemToSetOnEnable)
                AddItemToSet(this.gameObject);
        }

        private void OnDisable()
        {
            if (removeItemFromSetOnDisable)
                RemoveItemFromSet(this.gameObject);
        }

        private void AddItemToSet(GameObject item)
        {
            if (!set.runtimeSet.Contains(item))
                set.runtimeSet.Add(item);
        }

        private void RemoveItemFromSet(GameObject item)
        {
            if (set.runtimeSet.Contains(item))
                set.runtimeSet.Remove(item);
        }
    }
}
