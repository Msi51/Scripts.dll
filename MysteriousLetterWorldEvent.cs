using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class MysteriousLetterWorldEvent : BaseLetterWorldEvent
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IInventoryManager_ITextManager_ISpawnManager_IAIManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWorldEventType_Public_Virtual_WorldEventType_0;

	static MysteriousLetterWorldEvent()
	{
		Il2CppClassPointerStore<MysteriousLetterWorldEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MysteriousLetterWorldEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MysteriousLetterWorldEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_IInventoryManager_ITextManager_ISpawnManager_IAIManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MysteriousLetterWorldEvent>.NativeClassPtr, 100683689);
		NativeMethodInfoPtr_GetWorldEventType_Public_Virtual_WorldEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MysteriousLetterWorldEvent>.NativeClassPtr, 100683690);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268709, RefRangeEnd = 268710, XrefRangeStart = 268706, XrefRangeEnd = 268709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MysteriousLetterWorldEvent(IInventoryManager inventoryManager, ITextManager textManager, ISpawnManager spawnManager, IAIManager aiManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MysteriousLetterWorldEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IInventoryManager_ITextManager_ISpawnManager_IAIManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122147, RefRangeEnd = 122149, XrefRangeStart = 122147, XrefRangeEnd = 122149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override WorldEventType GetWorldEventType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWorldEventType_Public_Virtual_WorldEventType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(WorldEventType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public MysteriousLetterWorldEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
