#include "StdAfx.h"
#include "Native.h"
#import "..\bin\COMServer.tlb" no_namespace raw_interfaces_only

extern "C" __declspec(dllexport) void Init()
{
	CoInitializeEx(NULL, COINIT_MULTITHREADED);
	{
		IComServerPtr ptr;
		ptr.CreateInstance(__uuidof(ManagedServer));

		ptr->CallOnceOnSingleton();
	}
}
