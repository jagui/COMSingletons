﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SingletonLibrary;

namespace COMSingletons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling Singleton From Unmanaged");
            Init();
            Console.WriteLine("Calling Singleton From Managed");
            Singleton.Instance.CallOnce();
            Console.ReadLine();
        }

        [DllImport("NativeLibrary.dll")]
        private static extern void Init();
    }
}
