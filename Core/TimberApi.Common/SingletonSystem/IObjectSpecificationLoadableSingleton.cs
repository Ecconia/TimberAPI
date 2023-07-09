using Timberborn.SingletonSystem;

namespace TimberApi.Common.SingletonSystem
{
    [Singleton]
    public interface IObjectSpecificationLoadableSingleton
    {
        void SpecificationLoad();
    }
}