using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class IMappableToFromDictionary : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MapToDictionary_Public_Abstract_Virtual_New_Dictionary_2_String_Object_0;

	static IMappableToFromDictionary()
	{
		Il2CppClassPointerStore<IMappableToFromDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IMappableToFromDictionary");
		NativeMethodInfoPtr_MapToDictionary_Public_Abstract_Virtual_New_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMappableToFromDictionary>.NativeClassPtr, 100679375);
	}

	[CallerCount(0)]
	public unsafe virtual Dictionary<string, Il2CppSystem.Object> MapToDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MapToDictionary_Public_Abstract_Virtual_New_Dictionary_2_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
	}

	public IMappableToFromDictionary(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
