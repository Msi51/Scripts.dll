using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class ComponentEntityMapPool : BasePool<Dictionary<string, HashSet<Entity>>>
{
	private static readonly IntPtr NativeFieldInfoPtr_componentNames;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_Dictionary_2_String_HashSet_1_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_onRelease_Private_Static_Void_Dictionary_2_String_HashSet_1_Entity_0;

	public unsafe ICollection<string> componentNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentNames);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collection));
		}
	}

	static ComponentEntityMapPool()
	{
		Il2CppClassPointerStore<ComponentEntityMapPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ComponentEntityMapPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentEntityMapPool>.NativeClassPtr);
		NativeFieldInfoPtr_componentNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentEntityMapPool>.NativeClassPtr, "componentNames");
		NativeMethodInfoPtr__ctor_Public_Void_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentEntityMapPool>.NativeClassPtr, 100664460);
		NativeMethodInfoPtr_onCreate_Private_Dictionary_2_String_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentEntityMapPool>.NativeClassPtr, 100664461);
		NativeMethodInfoPtr_onRelease_Private_Static_Void_Dictionary_2_String_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentEntityMapPool>.NativeClassPtr, 100664462);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30544, RefRangeEnd = 30545, XrefRangeStart = 30517, XrefRangeEnd = 30544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComponentEntityMapPool(ICollection<string> componentNames)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentEntityMapPool>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)componentNames);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30545, XrefRangeEnd = 30577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30577, XrefRangeEnd = 30597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onRelease(Dictionary<string, HashSet<Entity>> map)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onRelease_Private_Static_Void_Dictionary_2_String_HashSet_1_Entity_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ComponentEntityMapPool(IntPtr pointer)
		: base(pointer)
	{
	}
}
