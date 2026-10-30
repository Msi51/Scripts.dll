using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ConstructionAbsentConsideration : AIConsideration
{
	private static readonly IntPtr NativeFieldInfoPtr_constructionIdentifier;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0;

	public unsafe string constructionIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ConstructionAbsentConsideration()
	{
		Il2CppClassPointerStore<ConstructionAbsentConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConstructionAbsentConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionAbsentConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_constructionIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionAbsentConsideration>.NativeClassPtr, "constructionIdentifier");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionAbsentConsideration>.NativeClassPtr, 100668245);
		NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionAbsentConsideration>.NativeClassPtr, 100668246);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 89001, RefRangeEnd = 89025, XrefRangeStart = 89001, XrefRangeEnd = 89025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConstructionAbsentConsideration(string constructionIdentifier)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionAbsentConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(constructionIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89317, XrefRangeEnd = 89319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public ConstructionAbsentConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}
