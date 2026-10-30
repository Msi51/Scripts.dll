using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IContextMenuActionFactory : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetContextMenuAction_Public_Abstract_Virtual_New_IContextMenuAction_ContextMenuActionType_Entity_InventorySlot_0;

	static IContextMenuActionFactory()
	{
		Il2CppClassPointerStore<IContextMenuActionFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IContextMenuActionFactory");
		NativeMethodInfoPtr_GetContextMenuAction_Public_Abstract_Virtual_New_IContextMenuAction_ContextMenuActionType_Entity_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextMenuActionFactory>.NativeClassPtr, 100669805);
	}

	[CallerCount(0)]
	public unsafe virtual IContextMenuAction GetContextMenuAction(ContextMenuActionType type, Entity actionEntity, InventorySlot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&type);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetContextMenuAction_Public_Abstract_Virtual_New_IContextMenuAction_ContextMenuActionType_Entity_InventorySlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IContextMenuAction>(intPtr) : null;
	}

	public IContextMenuActionFactory(IntPtr pointer)
		: base(pointer)
	{
	}
}
