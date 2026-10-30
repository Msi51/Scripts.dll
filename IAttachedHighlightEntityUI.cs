using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

public class IAttachedHighlightEntityUI : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetAttachedHighlightEntities_Public_Abstract_Virtual_New_Void_HashSet_1_Entity_0;

	static IAttachedHighlightEntityUI()
	{
		Il2CppClassPointerStore<IAttachedHighlightEntityUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IAttachedHighlightEntityUI");
		NativeMethodInfoPtr_GetAttachedHighlightEntities_Public_Abstract_Virtual_New_Void_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttachedHighlightEntityUI>.NativeClassPtr, 100667591);
	}

	[CallerCount(0)]
	public unsafe virtual void GetAttachedHighlightEntities(HashSet<Entity> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAttachedHighlightEntities_Public_Abstract_Virtual_New_Void_HashSet_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IAttachedHighlightEntityUI(IntPtr pointer)
		: base(pointer)
	{
	}
}
