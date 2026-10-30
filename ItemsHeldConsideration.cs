using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class ItemsHeldConsideration : AIConsideration
{
	private static readonly IntPtr NativeFieldInfoPtr_itemIdentifiers;

	private static readonly IntPtr NativeFieldInfoPtr_minAmount;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0;

	public unsafe HashSet<string> itemIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemIdentifiers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe int minAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minAmount)) = num;
		}
	}

	static ItemsHeldConsideration()
	{
		Il2CppClassPointerStore<ItemsHeldConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ItemsHeldConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemsHeldConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_itemIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemsHeldConsideration>.NativeClassPtr, "itemIdentifiers");
		NativeFieldInfoPtr_minAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemsHeldConsideration>.NativeClassPtr, "minAmount");
		NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemsHeldConsideration>.NativeClassPtr, 100668328);
		NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemsHeldConsideration>.NativeClassPtr, 100668329);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 89833, RefRangeEnd = 89842, XrefRangeStart = 89825, XrefRangeEnd = 89833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemsHeldConsideration(List<string> itemIdentifiers, int minAmount = 0)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemsHeldConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIdentifiers);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &minAmount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89842, XrefRangeEnd = 89863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public ItemsHeldConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}
