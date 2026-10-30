using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using strange.extensions.injector.api;

public class TradeEventHandler : NetworkedGameEventHandler<TradeEventParams, TradeEventResult>
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MinimumFairTradeRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_dropItemStackEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiManager;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_TradeEventResult_Int32_TradeEventParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addOrDropStack_Private_Void_InventoryItemStack_Int32_Inventory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_validateTradeItems_Private_Boolean_Inventory_List_1_TradeItemStack_List_1_ValueTuple_2_InventoryItemStack_Int32_byref_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_TradeEventResult_Boolean_0;

	public unsafe static float MinimumFairTradeRatio
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinimumFairTradeRatio, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinimumFairTradeRatio, (void*)(&num));
		}
	}

	public unsafe DropItemStackEvent dropItemStackEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropItemStackEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DropItemStackEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropItemStackEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dropItemStackEvent));
		}
	}

	public unsafe IAIManager aiManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAIManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iAIManager));
		}
	}

	static TradeEventHandler()
	{
		Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TradeEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr);
		NativeFieldInfoPtr_MinimumFairTradeRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr, "MinimumFairTradeRatio");
		NativeFieldInfoPtr_dropItemStackEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr, "dropItemStackEvent");
		NativeFieldInfoPtr_aiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr, "aiManager");
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr, 100670376);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr, 100670377);
		NativeMethodInfoPtr_Execute_Public_Virtual_TradeEventResult_Int32_TradeEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr, 100670378);
		NativeMethodInfoPtr_addOrDropStack_Private_Void_InventoryItemStack_Int32_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr, 100670379);
		NativeMethodInfoPtr_validateTradeItems_Private_Boolean_Inventory_List_1_TradeItemStack_List_1_ValueTuple_2_InventoryItemStack_Int32_byref_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr, 100670380);
		NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_TradeEventResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr, 100670381);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119163, RefRangeEnd = 119164, XrefRangeStart = 119160, XrefRangeEnd = 119163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TradeEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TradeEventHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119164, XrefRangeEnd = 119173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119173, XrefRangeEnd = 119283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override TradeEventResult Execute(int clientId, TradeEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&clientId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventParams));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_TradeEventResult_Int32_TradeEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new TradeEventResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119291, RefRangeEnd = 119293, XrefRangeStart = 119283, XrefRangeEnd = 119291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addOrDropStack(InventoryItemStack stack, int quantity, Inventory destinationInventory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quantity;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationInventory);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addOrDropStack_Private_Void_InventoryItemStack_Int32_Inventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119360, RefRangeEnd = 119362, XrefRangeStart = 119293, XrefRangeEnd = 119360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool validateTradeItems(Inventory inventory, List<TradeItemStack> stacks, List<Il2CppSystem.ValueTuple<InventoryItemStack, int>> resultStacks, ref int worth, float modifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stacks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultStacks);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref worth);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &modifier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_validateTradeItems_Private_Boolean_Inventory_List_1_TradeItemStack_List_1_ValueTuple_2_InventoryItemStack_Int32_byref_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void HandleResult(TradeEventResult result, bool relayResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &relayResult;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_TradeEventResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TradeEventHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
