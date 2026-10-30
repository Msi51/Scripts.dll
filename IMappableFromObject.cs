using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class IMappableFromObject : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromObject_Public_Abstract_Virtual_New_Void_Object_0;

	static IMappableFromObject()
	{
		Il2CppClassPointerStore<IMappableFromObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IMappableFromObject");
		NativeMethodInfoPtr_MapFromObject_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMappableFromObject>.NativeClassPtr, 100679374);
	}

	[CallerCount(0)]
	public unsafe virtual void MapFromObject(Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MapFromObject_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IMappableFromObject(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
