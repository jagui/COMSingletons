using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SingletonLibrary;

namespace COMServer
{
    [Guid("A0D470AF-0618-40E9-8297-8C63BAF3F1C3")]
    [ComVisible(true)]
    public interface IComServer
    {
        void CallOnceOnSingleton();
    }

    [Guid("9E9E5403-7993-49ED-BAFA-FD9A63A837E3")]
    [ComVisible(true)]
    public class ManagedServer: IComServer
    {
        private readonly Singleton _singleton;
        public ManagedServer()
        {
            _singleton = Singleton.Instance;
        }

        public void CallOnceOnSingleton()
        {
            _singleton.CallOnce();
        }
    }
}
