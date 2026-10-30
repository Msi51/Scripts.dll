using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;

public sealed class StartHealingEventParams : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_healingEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalItemSlotIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_healWithoutItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalToolSlotIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_numConsumablesUsing;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressableUI;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

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

	public unsafe InjuryLocation injuryLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryLocation);
			return *(InjuryLocation*)num;
		}
		set
		{
			*(InjuryLocation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryLocation)) = injuryLocation;
		}
	}

	public unsafe int healingEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_healingEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_healingEntityId)) = num;
		}
	}

	public unsafe InventorySlotIndex medicalItemSlotIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalItemSlotIndex);
			return *(InventorySlotIndex*)num;
		}
		set
		{
			*(InventorySlotIndex*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalItemSlotIndex)) = inventorySlotIndex;
		}
	}

	public unsafe bool healWithoutItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_healWithoutItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_healWithoutItem)) = flag;
		}
	}

	public unsafe InventorySlotIndex medicalToolSlotIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalToolSlotIndex);
			return *(InventorySlotIndex*)num;
		}
		set
		{
			*(InventorySlotIndex*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalToolSlotIndex)) = inventorySlotIndex;
		}
	}

	public unsafe int numConsumablesUsing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numConsumablesUsing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numConsumablesUsing)) = num;
		}
	}

	public unsafe IProgressableUI progressableUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressableUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IProgressableUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressableUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progressableUI));
		}
	}

	static StartHealingEventParams()
	{
		Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartHealingEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_injuryIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr, "injuryIdentifier");
		NativeFieldInfoPtr_injuryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr, "injuryLocation");
		NativeFieldInfoPtr_healingEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr, "healingEntityId");
		NativeFieldInfoPtr_medicalItemSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr, "medicalItemSlotIndex");
		NativeFieldInfoPtr_healWithoutItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr, "healWithoutItem");
		NativeFieldInfoPtr_medicalToolSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr, "medicalToolSlotIndex");
		NativeFieldInfoPtr_numConsumablesUsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr, "numConsumablesUsing");
		NativeFieldInfoPtr_progressableUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr, "progressableUI");
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr, 100663511);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4424, XrefRangeEnd = 4431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartHealingEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public StartHealingEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartHealingEventParams>.NativeClassPtr))
	{
	}
}
