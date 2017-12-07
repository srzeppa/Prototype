using System;
using DeepPrototype.Model;

namespace DeepPrototype
{
    [Serializable]
    public abstract class PlayerAbstract
    {
        public abstract Player Clone();
    }
}
