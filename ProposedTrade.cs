using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

public class ProposedTrade : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_traderEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_tradeeEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_traderStacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_tradeeStacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_traderStackAmounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_tradeeStackAmounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_onTradeUpdated;

	private static readonly System.IntPtr NativeFieldInfoPtr_traderMarginModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_tradeeMarginModifier;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TraderStacksPresent_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TradeeStacksPresent_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorthRatio_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTraderWorth_Public_Money_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTradeeWorth_Public_Money_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsProposedToSell_Public_Boolean_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsProposedToBuy_Public_Boolean_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllStacks_Public_Void_List_1_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTraderStacks_Public_Void_List_1_ValueTuple_3_InventoryItemStack_Int32_Money_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTradeeStacks_Public_Void_List_1_ValueTuple_3_InventoryItemStack_Int32_Money_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTraderStackAmount_Public_Int32_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTradeeStackAmount_Public_Int32_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemainingTraderStackAmount_Public_Int32_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemainingTradeeStackAmount_Public_Int32_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isStackPartOfExistingTrade_Private_Boolean_InventoryItemStack_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeDescendantStacks_Private_Void_InventoryItemStack_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddStack_Public_Boolean_InventoryItemStack_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTraderStack_Public_Void_InventoryItemStack_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTradeeStack_Public_Void_InventoryItemStack_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyStack_Public_Void_InventoryItemStack_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveStack_Public_Void_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkMessage_Public_ProposedTradeNetworkMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	public unsafe Entity traderEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traderEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traderEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Entity tradeeEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeeEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeeEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe List<InventoryItemStack> traderStacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traderStacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InventoryItemStack>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traderStacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InventoryItemStack> tradeeStacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeeStacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InventoryItemStack>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeeStacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<InventoryItemStack, int> traderStackAmounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traderStackAmounts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InventoryItemStack, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traderStackAmounts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InventoryItemStack, int> tradeeStackAmounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeeStackAmounts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InventoryItemStack, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeeStackAmounts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe UnityEvent onTradeUpdated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTradeUpdated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTradeUpdated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe float traderMarginModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traderMarginModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traderMarginModifier)) = num;
		}
	}

	public unsafe float tradeeMarginModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeeMarginModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeeMarginModifier)) = num;
		}
	}

	public unsafe bool TraderStacksPresent
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234821, RefRangeEnd = 234822, XrefRangeStart = 234820, XrefRangeEnd = 234821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TraderStacksPresent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool TradeeStacksPresent
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234823, RefRangeEnd = 234824, XrefRangeStart = 234822, XrefRangeEnd = 234823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TradeeStacksPresent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ProposedTrade()
	{
		Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ProposedTrade");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr);
		NativeFieldInfoPtr_traderEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, "traderEntity");
		NativeFieldInfoPtr_tradeeEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, "tradeeEntity");
		NativeFieldInfoPtr_traderStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, "traderStacks");
		NativeFieldInfoPtr_tradeeStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, "tradeeStacks");
		NativeFieldInfoPtr_traderStackAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, "traderStackAmounts");
		NativeFieldInfoPtr_tradeeStackAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, "tradeeStackAmounts");
		NativeFieldInfoPtr_onTradeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, "onTradeUpdated");
		NativeFieldInfoPtr_traderMarginModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, "traderMarginModifier");
		NativeFieldInfoPtr_tradeeMarginModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, "tradeeMarginModifier");
		NativeMethodInfoPtr_get_TraderStacksPresent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679852);
		NativeMethodInfoPtr_get_TradeeStacksPresent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679853);
		NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679854);
		NativeMethodInfoPtr_GetWorthRatio_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679855);
		NativeMethodInfoPtr_GetTraderWorth_Public_Money_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679856);
		NativeMethodInfoPtr_GetTradeeWorth_Public_Money_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679857);
		NativeMethodInfoPtr_IsProposedToSell_Public_Boolean_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679858);
		NativeMethodInfoPtr_IsProposedToBuy_Public_Boolean_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679859);
		NativeMethodInfoPtr_GetAllStacks_Public_Void_List_1_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679860);
		NativeMethodInfoPtr_GetTraderStacks_Public_Void_List_1_ValueTuple_3_InventoryItemStack_Int32_Money_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679861);
		NativeMethodInfoPtr_GetTradeeStacks_Public_Void_List_1_ValueTuple_3_InventoryItemStack_Int32_Money_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679862);
		NativeMethodInfoPtr_GetTraderStackAmount_Public_Int32_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679863);
		NativeMethodInfoPtr_GetTradeeStackAmount_Public_Int32_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679864);
		NativeMethodInfoPtr_RemainingTraderStackAmount_Public_Int32_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679865);
		NativeMethodInfoPtr_RemainingTradeeStackAmount_Public_Int32_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679866);
		NativeMethodInfoPtr_isStackPartOfExistingTrade_Private_Boolean_InventoryItemStack_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679867);
		NativeMethodInfoPtr_removeDescendantStacks_Private_Void_InventoryItemStack_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679868);
		NativeMethodInfoPtr_AddStack_Public_Boolean_InventoryItemStack_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679869);
		NativeMethodInfoPtr_AddTraderStack_Public_Void_InventoryItemStack_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679870);
		NativeMethodInfoPtr_AddTradeeStack_Public_Void_InventoryItemStack_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679871);
		NativeMethodInfoPtr_ModifyStack_Public_Void_InventoryItemStack_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679872);
		NativeMethodInfoPtr_RemoveStack_Public_Void_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679873);
		NativeMethodInfoPtr_GetNetworkMessage_Public_ProposedTradeNetworkMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679874);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr, 100679875);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234864, RefRangeEnd = 234865, XrefRangeStart = 234824, XrefRangeEnd = 234864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProposedTrade(Entity traderEntity, Entity tradeeEntity)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProposedTrade>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)traderEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tradeeEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234870, RefRangeEnd = 234872, XrefRangeStart = 234865, XrefRangeEnd = 234870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWorthRatio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorthRatio_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234893, RefRangeEnd = 234895, XrefRangeStart = 234872, XrefRangeEnd = 234893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Money GetTraderWorth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTraderWorth_Public_Money_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Money*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234916, RefRangeEnd = 234918, XrefRangeStart = 234895, XrefRangeEnd = 234916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Money GetTradeeWorth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTradeeWorth_Public_Money_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Money*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234918, XrefRangeEnd = 234922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsProposedToSell(InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsProposedToSell_Public_Boolean_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234922, XrefRangeEnd = 234926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsProposedToBuy(InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsProposedToBuy_Public_Boolean_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234955, RefRangeEnd = 234956, XrefRangeStart = 234926, XrefRangeEnd = 234955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAllStacks(List<InventoryItemStack> stacks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stacks);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllStacks_Public_Void_List_1_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234981, RefRangeEnd = 234982, XrefRangeStart = 234956, XrefRangeEnd = 234981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetTraderStacks(List<Il2CppSystem.ValueTuple<InventoryItemStack, int, Money>> stacks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stacks);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTraderStacks_Public_Void_List_1_ValueTuple_3_InventoryItemStack_Int32_Money_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235007, RefRangeEnd = 235008, XrefRangeStart = 234982, XrefRangeEnd = 235007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetTradeeStacks(List<Il2CppSystem.ValueTuple<InventoryItemStack, int, Money>> stacks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stacks);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTradeeStacks_Public_Void_List_1_ValueTuple_3_InventoryItemStack_Int32_Money_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235008, XrefRangeEnd = 235011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTraderStackAmount(InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTraderStackAmount_Public_Int32_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235011, XrefRangeEnd = 235014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTradeeStackAmount(InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTradeeStackAmount_Public_Int32_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235014, XrefRangeEnd = 235017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int RemainingTraderStackAmount(InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemainingTraderStackAmount_Public_Int32_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235017, XrefRangeEnd = 235020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int RemainingTradeeStackAmount(InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemainingTradeeStackAmount_Public_Int32_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235028, RefRangeEnd = 235030, XrefRangeStart = 235020, XrefRangeEnd = 235028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isStackPartOfExistingTrade(InventoryItemStack stack, bool trader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trader;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isStackPartOfExistingTrade_Private_Boolean_InventoryItemStack_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235057, RefRangeEnd = 235059, XrefRangeStart = 235030, XrefRangeEnd = 235057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeDescendantStacks(InventoryItemStack parentStack, bool trader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentStack);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trader;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeDescendantStacks_Private_Void_InventoryItemStack_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235094, RefRangeEnd = 235095, XrefRangeStart = 235059, XrefRangeEnd = 235094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddStack(InventoryItemStack stack, int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddStack_Public_Boolean_InventoryItemStack_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235095, XrefRangeEnd = 235109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTraderStack(InventoryItemStack stack, int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTraderStack_Public_Void_InventoryItemStack_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235109, XrefRangeEnd = 235123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTradeeStack(InventoryItemStack stack, int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTradeeStack_Public_Void_InventoryItemStack_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235135, RefRangeEnd = 235136, XrefRangeStart = 235123, XrefRangeEnd = 235135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyStack(InventoryItemStack stack, int quantity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quantity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyStack_Public_Void_InventoryItemStack_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235148, RefRangeEnd = 235150, XrefRangeStart = 235136, XrefRangeEnd = 235148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveStack(InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveStack_Public_Void_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235200, RefRangeEnd = 235202, XrefRangeStart = 235150, XrefRangeEnd = 235200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProposedTradeNetworkMessage GetNetworkMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNetworkMessage_Public_ProposedTradeNetworkMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ProposedTradeNetworkMessage(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235212, RefRangeEnd = 235213, XrefRangeStart = 235202, XrefRangeEnd = 235212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ProposedTrade(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
