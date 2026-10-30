using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class EntitySave : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nextEntityId;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int nextEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextEntityId)) = num;
		}
	}

	static EntitySave()
	{
		Il2CppClassPointerStore<EntitySave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EntitySave");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitySave>.NativeClassPtr);
		NativeFieldInfoPtr_nextEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySave>.NativeClassPtr, "nextEntityId");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitySave>.NativeClassPtr, 100674651);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EntitySave()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntitySave>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EntitySave(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
