using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class IMappableFromDictionary : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Abstract_Virtual_New_Void_Dictionary_2_String_Object_0;

	static IMappableFromDictionary()
	{
		Il2CppClassPointerStore<IMappableFromDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IMappableFromDictionary");
		NativeMethodInfoPtr_MapFromDictionary_Public_Abstract_Virtual_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMappableFromDictionary>.NativeClassPtr, 100679373);
	}

	[CallerCount(0)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MapFromDictionary_Public_Abstract_Virtual_New_Void_Dictionary_2_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IMappableFromDictionary(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
