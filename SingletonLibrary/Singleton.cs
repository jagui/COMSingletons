using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonLibrary
{
    public sealed class Singleton
    {
        private Boolean _calledOnce;

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return Nested.Singleton;
            }
        }

        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton Singleton = new Singleton();
        }

        public void CallOnce()
        {
            if (_calledOnce)
                throw new InvalidOperationException("CallOnce called twice on singleton");
            _calledOnce = true;
        }
    }
}
