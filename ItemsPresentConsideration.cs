using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class ItemsPresentConsideration : AIConsideration
{
	private static readonly System.IntPtr NativeFieldInfoPtr_itemIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_atLeastAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_atMostAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_validAmountFunc;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Func_3_AIContext_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0;

	public unsafe List<string> itemIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemIdentifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int atLeastAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atLeastAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atLeastAmount)) = num;
		}
	}

	public unsafe int atMostAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atMostAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atMostAmount)) = num;
		}
	}

	public unsafe Il2CppSystem.Func<AIContext, int, bool> validAmountFunc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validAmountFunc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<AIContext, int, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validAmountFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	static ItemsPresentConsideration()
	{
		Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ItemsPresentConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_itemIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr, "itemIdentifiers");
		NativeFieldInfoPtr_atLeastAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr, "atLeastAmount");
		NativeFieldInfoPtr_atMostAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr, "atMostAmount");
		NativeFieldInfoPtr_validAmountFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr, "validAmountFunc");
		NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr, 100668332);
		NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Func_3_AIContext_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr, 100668333);
		NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr, 100668334);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89898, XrefRangeEnd = 89900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemsPresentConsideration(List<string> itemIdentifiers, int atLeastAmount, int atMostAmount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIdentifiers);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &atLeastAmount;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &atMostAmount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89903, RefRangeEnd = 89904, XrefRangeStart = 89900, XrefRangeEnd = 89903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemsPresentConsideration(List<string> itemIdentifiers, Il2CppSystem.Func<AIContext, int, bool> validAmountFunc)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemsPresentConsideration>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIdentifiers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)validAmountFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_String_Func_3_AIContext_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89904, XrefRangeEnd = 89941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float Score(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ItemsPresentConsideration(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
