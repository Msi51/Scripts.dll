using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IDeadGrowable : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetPhase_Public_Abstract_Virtual_New_Void_Int32_Single_0;

	static IDeadGrowable()
	{
		Il2CppClassPointerStore<IDeadGrowable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IDeadGrowable");
		NativeMethodInfoPtr_SetPhase_Public_Abstract_Virtual_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeadGrowable>.NativeClassPtr, 100681386);
	}

	[CallerCount(0)]
	public unsafe virtual void SetPhase(int index, float size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &size;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetPhase_Public_Abstract_Virtual_New_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IDeadGrowable(IntPtr pointer)
		: base(pointer)
	{
	}
}
