using UniRx;
using UnityEngine;

namespace Saito.Gimick5
{
    public class Gimick5Model : MonoBehaviour
    {
        private BoolReactiveProperty _value = new BoolReactiveProperty(false);
        public IReadOnlyReactiveProperty<bool> Value => _value;

        public void UpdateValue(bool value)
        {
            _value.Value = value;
        }
    }
}