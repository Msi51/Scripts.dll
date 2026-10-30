using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class BaseLetterWorldEvent : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TARGET_CONSTRUCTION_IDENTIFIER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TARGET_CONSTRUCTION_MIN_RANGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_textManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_letterTextIdentifier;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IInventoryManager_ITextManager_ISpawnManager_IAIManager_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldEventType_Public_Abstract_Virtual_New_WorldEventType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Boolean_World_0;

	public unsafe static string TARGET_CONSTRUCTION_IDENTIFIER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TARGET_CONSTRUCTION_IDENTIFIER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TARGET_CONSTRUCTION_IDENTIFIER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static float TARGET_CONSTRUCTION_MIN_RANGE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TARGET_CONSTRUCTION_MIN_RANGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TARGET_CONSTRUCTION_MIN_RANGE, (void*)(&num));
		}
	}

	public unsafe IInventoryManager inventoryManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager));
		}
	}

	public unsafe ITextManager textManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ITextManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textManager));
		}
	}

	public unsafe ISpawnManager spawnManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISpawnManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnManager));
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

	public unsafe string letterTextIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_letterTextIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_letterTextIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static BaseLetterWorldEvent()
	{
		Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "BaseLetterWorldEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr);
		NativeFieldInfoPtr_TARGET_CONSTRUCTION_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr, "TARGET_CONSTRUCTION_IDENTIFIER");
		NativeFieldInfoPtr_TARGET_CONSTRUCTION_MIN_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr, "TARGET_CONSTRUCTION_MIN_RANGE");
		NativeFieldInfoPtr_inventoryManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr, "inventoryManager");
		NativeFieldInfoPtr_textManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr, "textManager");
		NativeFieldInfoPtr_spawnManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr, "spawnManager");
		NativeFieldInfoPtr_aiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr, "aiManager");
		NativeFieldInfoPtr_letterTextIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr, "letterTextIdentifier");
		NativeMethodInfoPtr__ctor_Public_Void_IInventoryManager_ITextManager_ISpawnManager_IAIManager_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr, 100683675);
		NativeMethodInfoPtr_GetWorldEventType_Public_Abstract_Virtual_New_WorldEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr, 100683676);
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr, 100683677);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 268398, RefRangeEnd = 268402, XrefRangeStart = 268392, XrefRangeEnd = 268398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseLetterWorldEvent(IInventoryManager inventoryManager, ITextManager textManager, ISpawnManager spawnManager, IAIManager aiManager, string letterTextIdentifier)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseLetterWorldEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(letterTextIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IInventoryManager_ITextManager_ISpawnManager_IAIManager_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual WorldEventType GetWorldEventType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWorldEventType_Public_Abstract_Virtual_New_WorldEventType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(WorldEventType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268402, XrefRangeEnd = 268488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public BaseLetterWorldEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
