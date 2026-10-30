using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class ICursorChangeUI : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorType_Public_Abstract_Virtual_New_Nullable_1_CursorType_0;

	static ICursorChangeUI()
	{
		Il2CppClassPointerStore<ICursorChangeUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ICursorChangeUI");
		NativeMethodInfoPtr_GetCursorType_Public_Abstract_Virtual_New_Nullable_1_CursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICursorChangeUI>.NativeClassPtr, 100667596);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppSystem.Nullable<CursorType> GetCursorType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCursorType_Public_Abstract_Virtual_New_Nullable_1_CursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<CursorType>(pointer);
	}

	public ICursorChangeUI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
