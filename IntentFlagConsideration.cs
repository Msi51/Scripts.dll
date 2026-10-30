using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IntentFlagConsideration : AIConsideration
{
	private static readonly IntPtr NativeFieldInfoPtr_flag;

	private static readonly IntPtr NativeFieldInfoPtr_cleanOnActionExit;

	private static readonly IntPtr NativeFieldInfoPtr_scoreWhenPresent;

	private static readonly IntPtr NativeFieldInfoPtr_startOnly;

	private static readonly IntPtr NativeFieldInfoPtr_possibleValues;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetFlag_Public_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetOwningAction_Public_Virtual_Void_AIAction_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0;

	public unsafe string flag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flag);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flag)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool cleanOnActionExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanOnActionExit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanOnActionExit)) = flag;
		}
	}

	public unsafe float scoreWhenPresent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scoreWhenPresent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scoreWhenPresent)) = num;
		}
	}

	public unsafe bool startOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startOnly)) = flag;
		}
	}

	public unsafe List<string> possibleValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleValues);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleValues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static IntentFlagConsideration()
	{
		Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IntentFlagConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr, "flag");
		NativeFieldInfoPtr_cleanOnActionExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr, "cleanOnActionExit");
		NativeFieldInfoPtr_scoreWhenPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr, "scoreWhenPresent");
		NativeFieldInfoPtr_startOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr, "startOnly");
		NativeFieldInfoPtr_possibleValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr, "possibleValues");
		NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr, 100668315);
		NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr, 100668316);
		NativeMethodInfoPtr_GetFlag_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr, 100668317);
		NativeMethodInfoPtr_SetOwningAction_Public_Virtual_Void_AIAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr, 100668318);
		NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr, 100668319);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 89761, RefRangeEnd = 89772, XrefRangeStart = 89759, XrefRangeEnd = 89761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntentFlagConsideration(string flag, bool cleanOnActionExit = true, bool startOnly = true, float scoreWhenPresent = 1f)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(flag);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &cleanOnActionExit;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &startOnly;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &scoreWhenPresent;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89772, XrefRangeEnd = 89775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntentFlagConsideration(string flag, List<string> possibleValues, bool cleanOnActionExit = true, bool startOnly = true, float scoreWhenPresent = 1f)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntentFlagConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(flag);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)possibleValues);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &cleanOnActionExit;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startOnly;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &scoreWhenPresent;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18747, RefRangeEnd = 18748, XrefRangeStart = 18747, XrefRangeEnd = 18748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFlag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFlag_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89775, XrefRangeEnd = 89777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetOwningAction(AIAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetOwningAction_Public_Virtual_Void_AIAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89777, XrefRangeEnd = 89781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public IntentFlagConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}
