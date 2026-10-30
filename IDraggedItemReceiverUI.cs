using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IDraggedItemReceiverUI : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ShouldReceiveDraggedItem_Public_Virtual_New_Boolean_0;

	static IDraggedItemReceiverUI()
	{
		Il2CppClassPointerStore<IDraggedItemReceiverUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IDraggedItemReceiverUI");
		NativeMethodInfoPtr_ShouldReceiveDraggedItem_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDraggedItemReceiverUI>.NativeClassPtr, 100666785);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 44231, RefRangeEnd = 44249, XrefRangeStart = 44231, XrefRangeEnd = 44249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ShouldReceiveDraggedItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShouldReceiveDraggedItem_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IDraggedItemReceiverUI(IntPtr pointer)
		: base(pointer)
	{
	}
}
