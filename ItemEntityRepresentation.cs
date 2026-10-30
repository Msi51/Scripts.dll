using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class ItemEntityRepresentation : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_serializedEntity;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SerializedEntity serializedEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serializedEntity);
			return new SerializedEntity(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serializedEntity), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializedEntity)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static ItemEntityRepresentation()
	{
		Il2CppClassPointerStore<ItemEntityRepresentation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ItemEntityRepresentation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemEntityRepresentation>.NativeClassPtr);
		NativeFieldInfoPtr_serializedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemEntityRepresentation>.NativeClassPtr, "serializedEntity");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemEntityRepresentation>.NativeClassPtr, 100673508);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemEntityRepresentation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemEntityRepresentation>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ItemEntityRepresentation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
