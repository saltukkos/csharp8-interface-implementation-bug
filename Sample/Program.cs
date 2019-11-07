using System;

namespace Sample
{
    public interface IFoo<T>
    {
        sealed Type GetItemType() => typeof(T);
    }

    public sealed class Foo : IFoo<string>
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFoo<string> foo = new Foo();
            foo.GetItemType();
        }
    }
}
