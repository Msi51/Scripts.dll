using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class CraftingState : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_queue;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveRecipe_Public_get_CraftingRecipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveRecipe_Public_set_Void_CraftingRecipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ProgressPercentage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ProgressPercentage_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_QueuedRecipes_Public_get_Queue_1_CraftingRecipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueRecipe_Public_Void_CraftingRecipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasRecipeQueued_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DequeueRecipe_Public_CraftingRecipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DequeueRecipe_Public_Void_CraftingRecipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DequeueRecipe_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetToolStack_Public_InventoryItemStack_CraftingRecipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetToolStack_Public_Void_CraftingRecipe_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQueuedRecipeCount_Public_Int32_CraftingRecipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearQueuedRecipes_Public_Void_0;

	public unsafe ToolableElementQueue<CraftingRecipe> queue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ToolableElementQueue<CraftingRecipe>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toolableElementQueue));
		}
	}

	public unsafe CraftingRecipe ActiveRecipe
	{
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 103573, RefRangeEnd = 103594, XrefRangeStart = 103573, XrefRangeEnd = 103573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActiveRecipe_Public_get_CraftingRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CraftingRecipe>(intPtr) : null;
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 103596, RefRangeEnd = 103600, XrefRangeStart = 103594, XrefRangeEnd = 103596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ActiveRecipe_Public_set_Void_CraftingRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float ProgressPercentage
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 103600, RefRangeEnd = 103604, XrefRangeStart = 103600, XrefRangeEnd = 103600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ProgressPercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 103604, RefRangeEnd = 103610, XrefRangeStart = 103604, XrefRangeEnd = 103604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ProgressPercentage_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Queue<CraftingRecipe> QueuedRecipes
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103611, RefRangeEnd = 103613, XrefRangeStart = 103610, XrefRangeEnd = 103611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_QueuedRecipes_Public_get_Queue_1_CraftingRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<CraftingRecipe>>(intPtr) : null;
		}
	}

	static CraftingState()
	{
		Il2CppClassPointerStore<CraftingState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CraftingState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CraftingState>.NativeClassPtr);
		NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, "queue");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669545);
		NativeMethodInfoPtr_get_ActiveRecipe_Public_get_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669546);
		NativeMethodInfoPtr_set_ActiveRecipe_Public_set_Void_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669547);
		NativeMethodInfoPtr_get_ProgressPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669548);
		NativeMethodInfoPtr_set_ProgressPercentage_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669549);
		NativeMethodInfoPtr_get_QueuedRecipes_Public_get_Queue_1_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669550);
		NativeMethodInfoPtr_QueueRecipe_Public_Void_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669551);
		NativeMethodInfoPtr_HasRecipeQueued_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669552);
		NativeMethodInfoPtr_DequeueRecipe_Public_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669553);
		NativeMethodInfoPtr_DequeueRecipe_Public_Void_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669554);
		NativeMethodInfoPtr_DequeueRecipe_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669555);
		NativeMethodInfoPtr_GetToolStack_Public_InventoryItemStack_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669556);
		NativeMethodInfoPtr_SetToolStack_Public_Void_CraftingRecipe_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669557);
		NativeMethodInfoPtr_GetQueuedRecipeCount_Public_Int32_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669558);
		NativeMethodInfoPtr_ClearQueuedRecipes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingState>.NativeClassPtr, 100669559);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 103572, RefRangeEnd = 103573, XrefRangeStart = 103563, XrefRangeEnd = 103572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CraftingState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CraftingState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 103617, RefRangeEnd = 103619, XrefRangeStart = 103613, XrefRangeEnd = 103617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueRecipe(CraftingRecipe recipe)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recipe);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueRecipe_Public_Void_CraftingRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 103623, RefRangeEnd = 103625, XrefRangeStart = 103619, XrefRangeEnd = 103623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasRecipeQueued()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasRecipeQueued_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 103629, RefRangeEnd = 103630, XrefRangeStart = 103625, XrefRangeEnd = 103629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CraftingRecipe DequeueRecipe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DequeueRecipe_Public_CraftingRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CraftingRecipe>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 103634, RefRangeEnd = 103635, XrefRangeStart = 103630, XrefRangeEnd = 103634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DequeueRecipe(CraftingRecipe recipe)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recipe);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DequeueRecipe_Public_Void_CraftingRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103635, XrefRangeEnd = 103639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DequeueRecipe(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DequeueRecipe_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 103643, RefRangeEnd = 103651, XrefRangeStart = 103639, XrefRangeEnd = 103643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InventoryItemStack GetToolStack(CraftingRecipe element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetToolStack_Public_InventoryItemStack_CraftingRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 103655, RefRangeEnd = 103657, XrefRangeStart = 103651, XrefRangeEnd = 103655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetToolStack(CraftingRecipe element, InventoryItemStack toolStack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toolStack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetToolStack_Public_Void_CraftingRecipe_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 103661, RefRangeEnd = 103667, XrefRangeStart = 103657, XrefRangeEnd = 103661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetQueuedRecipeCount(CraftingRecipe recipe)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recipe);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQueuedRecipeCount_Public_Int32_CraftingRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 103671, RefRangeEnd = 103672, XrefRangeStart = 103667, XrefRangeEnd = 103671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearQueuedRecipes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearQueuedRecipes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CraftingState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
