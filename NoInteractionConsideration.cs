using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class NoInteractionConsideration : AIConsideration
{
	private static readonly IntPtr NativeFieldInfoPtr_entityIdentifier;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0;

	public unsafe string entityIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static NoInteractionConsideration()
	{
		Il2CppClassPointerStore<NoInteractionConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NoInteractionConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInteractionConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_entityIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInteractionConsideration>.NativeClassPtr, "entityIdentifier");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInteractionConsideration>.NativeClassPtr, 100668345);
		NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInteractionConsideration>.NativeClassPtr, 100668346);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 89001, RefRangeEnd = 89025, XrefRangeStart = 89001, XrefRangeEnd = 89025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NoInteractionConsideration(string entityIdentifier)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInteractionConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(entityIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90001, XrefRangeEnd = 90033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float Score(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public NoInteractionConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}
