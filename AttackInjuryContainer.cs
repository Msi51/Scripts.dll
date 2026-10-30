using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class AttackInjuryContainer : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_injuryIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_applyChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_applyCategories;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	public unsafe string injuryIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float applyChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyChance)) = num;
		}
	}

	public unsafe List<InjuryCategory> applyCategories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyCategories);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InjuryCategory>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyCategories)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static AttackInjuryContainer()
	{
		Il2CppClassPointerStore<AttackInjuryContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AttackInjuryContainer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackInjuryContainer>.NativeClassPtr);
		NativeFieldInfoPtr_injuryIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackInjuryContainer>.NativeClassPtr, "injuryIdentifier");
		NativeFieldInfoPtr_applyChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackInjuryContainer>.NativeClassPtr, "applyChance");
		NativeFieldInfoPtr_applyCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackInjuryContainer>.NativeClassPtr, "applyCategories");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackInjuryContainer>.NativeClassPtr, 100670431);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121057, RefRangeEnd = 121058, XrefRangeStart = 121031, XrefRangeEnd = 121057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AttackInjuryContainer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AttackInjuryContainer()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackInjuryContainer>.NativeClassPtr))
	{
	}
}
