using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using strange.extensions.injector.api;

public class ConsumeInventoryAction : AIAction
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_AIConsideration_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_AIActionResult_AIContext_0;

	static ConsumeInventoryAction()
	{
		Il2CppClassPointerStore<ConsumeInventoryAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConsumeInventoryAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsumeInventoryAction>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_AIConsideration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryAction>.NativeClassPtr, 100668036);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryAction>.NativeClassPtr, 100668037);
		NativeMethodInfoPtr_Execute_Public_Virtual_AIActionResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryAction>.NativeClassPtr, 100668038);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 86249, RefRangeEnd = 86286, XrefRangeStart = 86249, XrefRangeEnd = 86286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConsumeInventoryAction(string identifier, [Optional] Il2CppReferenceArray<AIConsideration> considerations)
	{
		if (considerations == null)
		{
			considerations = new Il2CppReferenceArray<AIConsideration>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsumeInventoryAction>.NativeClassPtr));
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)considerations);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_AIConsideration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize(IInjectionBinder binder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86574, XrefRangeEnd = 86580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override AIActionResult Execute(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_AIActionResult_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AIActionResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ConsumeInventoryAction(string identifier, params AIConsideration[] considerations)
		: this(identifier, new Il2CppReferenceArray<AIConsideration>(considerations))
	{
	}

	public ConsumeInventoryAction(IntPtr pointer)
		: base(pointer)
	{
	}
}
