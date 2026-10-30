using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class ItemNearbyConsideration : AIConsideration<FindEntitiesResult>
{
	private static readonly System.IntPtr NativeFieldInfoPtr_identifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefabVariantType;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowStockpiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_range;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_PrefabVariantType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindEntitiesResult_AIContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindEntitiesResult_0;

	public unsafe List<string> identifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Il2CppSystem.Nullable<PrefabVariantType> prefabVariantType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabVariantType);
			return new Il2CppSystem.Nullable<PrefabVariantType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<PrefabVariantType>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabVariantType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nullable)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<PrefabVariantType>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool allowStockpiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowStockpiles);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowStockpiles)) = flag;
		}
	}

	public unsafe float range
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_range);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_range)) = num;
		}
	}

	static ItemNearbyConsideration()
	{
		Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ItemNearbyConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_identifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr, "identifiers");
		NativeFieldInfoPtr_prefabVariantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr, "prefabVariantType");
		NativeFieldInfoPtr_allowStockpiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr, "allowStockpiles");
		NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr, "range");
		NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr, 100668324);
		NativeMethodInfoPtr__ctor_Public_Void_List_1_String_PrefabVariantType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr, 100668325);
		NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindEntitiesResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr, 100668326);
		NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindEntitiesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr, 100668327);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89797, RefRangeEnd = 89798, XrefRangeStart = 89793, XrefRangeEnd = 89797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemNearbyConsideration(List<string> identifiers, bool allowStockpiles = true)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowStockpiles;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89805, RefRangeEnd = 89806, XrefRangeStart = 89798, XrefRangeEnd = 89805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemNearbyConsideration(List<string> identifiers, PrefabVariantType prefabVariantType, bool allowStockpiles = true)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemNearbyConsideration>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariantType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowStockpiles;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_String_PrefabVariantType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89806, XrefRangeEnd = 89825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override FindEntitiesResult ComputeResult(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindEntitiesResult_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindEntitiesResult(pointer);
	}

	[CallerCount(0)]
	public unsafe override float Score(AIContext ctx, FindEntitiesResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindEntitiesResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ItemNearbyConsideration(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
