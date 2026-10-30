using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IdentifierToEntitiesMapPool : BasePool<Dictionary<string, HashSet<Entity>>>
{
	private static readonly IntPtr NativeFieldInfoPtr_entityIdentifiers;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_Dictionary_2_String_HashSet_1_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_onRelease_Private_Static_Void_Dictionary_2_String_HashSet_1_Entity_0;

	public unsafe ICollection<string> entityIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityIdentifiers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collection));
		}
	}

	static IdentifierToEntitiesMapPool()
	{
		Il2CppClassPointerStore<IdentifierToEntitiesMapPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IdentifierToEntitiesMapPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdentifierToEntitiesMapPool>.NativeClassPtr);
		NativeFieldInfoPtr_entityIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdentifierToEntitiesMapPool>.NativeClassPtr, "entityIdentifiers");
		NativeMethodInfoPtr__ctor_Public_Void_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentifierToEntitiesMapPool>.NativeClassPtr, 100664487);
		NativeMethodInfoPtr_onCreate_Private_Dictionary_2_String_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentifierToEntitiesMapPool>.NativeClassPtr, 100664488);
		NativeMethodInfoPtr_onRelease_Private_Static_Void_Dictionary_2_String_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentifierToEntitiesMapPool>.NativeClassPtr, 100664489);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31111, RefRangeEnd = 31112, XrefRangeStart = 31084, XrefRangeEnd = 31111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IdentifierToEntitiesMapPool(ICollection<string> entityIdentifiers)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdentifierToEntitiesMapPool>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityIdentifiers);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31112, XrefRangeEnd = 31118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<string, HashSet<Entity>> onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_Dictionary_2_String_HashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<Entity>>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31118, XrefRangeEnd = 31138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onRelease(Dictionary<string, HashSet<Entity>> map)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onRelease_Private_Static_Void_Dictionary_2_String_HashSet_1_Entity_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IdentifierToEntitiesMapPool(IntPtr pointer)
		: base(pointer)
	{
	}
}
