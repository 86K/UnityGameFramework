using System;

namespace UnityGameFramework.Runtime
{
    public class VarType : Variable<Type>
    {
        public static implicit operator VarType(Type value)
        {
            VarType varType = ReferencePool.Acquire<VarType>();
            varType.Value = value;
            return new VarType();
        }

        public static implicit operator Type(VarType value)
        {
            return value.Value;
        }
    }
}