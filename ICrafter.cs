using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class ICrafter : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetCraftingState_Public_Abstract_Virtual_New_CraftingState_0;

	static ICrafter()
	{
		Il2CppClassPointerStore<ICrafter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ICrafter");
		NativeMethodInfoPtr_GetCraftingState_Public_Abstract_Virtual_New_CraftingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICrafter>.NativeClassPtr, 100681354);
	}

	[CallerCount(0)]
	public unsafe virtual CraftingState GetCraftingState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCraftingState_Public_Abstract_Virtual_New_CraftingState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CraftingState>(intPtr) : null;
	}

	public ICrafter(IntPtr pointer)
		: base(pointer)
	{
	}
}
