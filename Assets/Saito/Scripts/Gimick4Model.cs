using UniRx;
using UnityEngine;

namespace Saito.Gimick4
{
    public class Gimick4Model : MonoBehaviour
    {
        private BoolReactiveProperty _value = new BoolReactiveProperty(false);
        public IReadOnlyReactiveProperty<bool> Value => _value;

        public void UpdateValue(bool value)
        {
            _value.Value = value;
        }
    }
}