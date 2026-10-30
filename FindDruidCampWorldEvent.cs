using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class FindDruidCampWorldEvent : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_networkManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_CAMP_CHUNK_DISTANCE_MIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_CAMP_CHUNK_DISTANCE_MAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_coordinatesResult;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_INetworkManager_ICharacterManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldEventType_Public_Virtual_Final_New_WorldEventType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Boolean_World_0;

	public unsafe INetworkManager networkManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<INetworkManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager));
		}
	}

	public unsafe ICharacterManager characterManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICharacterManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterManager));
		}
	}

	public unsafe static float CAMP_CHUNK_DISTANCE_MIN
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CAMP_CHUNK_DISTANCE_MIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CAMP_CHUNK_DISTANCE_MIN, (void*)(&num));
		}
	}

	public unsafe static float CAMP_CHUNK_DISTANCE_MAX
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CAMP_CHUNK_DISTANCE_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CAMP_CHUNK_DISTANCE_MAX, (void*)(&num));
		}
	}

	public unsafe List<Coordinates> coordinatesResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinatesResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinatesResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static FindDruidCampWorldEvent()
	{
		Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FindDruidCampWorldEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr);
		NativeFieldInfoPtr_networkManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr, "networkManager");
		NativeFieldInfoPtr_characterManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr, "characterManager");
		NativeFieldInfoPtr_CAMP_CHUNK_DISTANCE_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr, "CAMP_CHUNK_DISTANCE_MIN");
		NativeFieldInfoPtr_CAMP_CHUNK_DISTANCE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr, "CAMP_CHUNK_DISTANCE_MAX");
		NativeFieldInfoPtr_coordinatesResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr, "coordinatesResult");
		NativeMethodInfoPtr__ctor_Public_Void_INetworkManager_ICharacterManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr, 100683682);
		NativeMethodInfoPtr_GetWorldEventType_Public_Virtual_Final_New_WorldEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr, 100683683);
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr, 100683684);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268574, RefRangeEnd = 268575, XrefRangeStart = 268563, XrefRangeEnd = 268574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FindDruidCampWorldEvent(INetworkManager networkManager, ICharacterManager characterManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FindDruidCampWorldEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterManager);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_INetworkManager_ICharacterManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 125135, RefRangeEnd = 125138, XrefRangeStart = 125135, XrefRangeEnd = 125138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual WorldEventType GetWorldEventType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldEventType_Public_Virtual_Final_New_WorldEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(WorldEventType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268575, XrefRangeEnd = 268702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Execute(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Boolean_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public FindDruidCampWorldEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
