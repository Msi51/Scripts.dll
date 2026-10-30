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

public sealed class StartSanitizingEventParams : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryHashId;

	private static readonly System.IntPtr NativeFieldInfoPtr_location;

	private static readonly System.IntPtr NativeFieldInfoPtr_sanitizingEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_antisepticSlotIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_sanitizeWithoutItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressableUI;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe int injuryHashId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryHashId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryHashId)) = num;
		}
	}

	public unsafe InjuryLocation location
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
			return *(InjuryLocation*)num;
		}
		set
		{
			*(InjuryLocation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)) = injuryLocation;
		}
	}

	public unsafe int sanitizingEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sanitizingEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sanitizingEntityId)) = num;
		}
	}

	public unsafe InventorySlotIndex antisepticSlotIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antisepticSlotIndex);
			return *(InventorySlotIndex*)num;
		}
		set
		{
			*(InventorySlotIndex*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antisepticSlotIndex)) = inventorySlotIndex;
		}
	}

	public unsafe bool sanitizeWithoutItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sanitizeWithoutItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sanitizeWithoutItem)) = flag;
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

	static StartSanitizingEventParams()
	{
		Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartSanitizingEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_injuryHashId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr, "injuryHashId");
		NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr, "location");
		NativeFieldInfoPtr_sanitizingEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr, "sanitizingEntityId");
		NativeFieldInfoPtr_antisepticSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr, "antisepticSlotIndex");
		NativeFieldInfoPtr_sanitizeWithoutItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr, "sanitizeWithoutItem");
		NativeFieldInfoPtr_progressableUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr, "progressableUI");
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr, 100663507);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4411, XrefRangeEnd = 4416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartSanitizingEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public StartSanitizingEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartSanitizingEventParams>.NativeClassPtr))
	{
	}
}
