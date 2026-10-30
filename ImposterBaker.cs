using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public class ImposterBaker : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Snapshot
	{
		static Snapshot()
		{
			Il2CppClassPointerStore<Snapshot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImposterBaker>.NativeClassPtr, "Snapshot");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	static ImposterBaker()
	{
		Il2CppClassPointerStore<ImposterBaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ImposterBaker");
	}

	public ImposterBaker(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
