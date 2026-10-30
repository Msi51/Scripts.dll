using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class OffsetExistingChildResourceMeshEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_parentEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_childEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_childResource;

	public unsafe int parentEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentEntityId)) = num;
		}
	}

	public unsafe int childEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childEntityId)) = num;
		}
	}

	public unsafe IResource childResource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childResource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IResource>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childResource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resource));
		}
	}

	static OffsetExistingChildResourceMeshEventParams()
	{
		Il2CppClassPointerStore<OffsetExistingChildResourceMeshEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "OffsetExistingChildResourceMeshEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffsetExistingChildResourceMeshEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_parentEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetExistingChildResourceMeshEventParams>.NativeClassPtr, "parentEntityId");
		NativeFieldInfoPtr_childEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetExistingChildResourceMeshEventParams>.NativeClassPtr, "childEntityId");
		NativeFieldInfoPtr_childResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetExistingChildResourceMeshEventParams>.NativeClassPtr, "childResource");
	}

	public OffsetExistingChildResourceMeshEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public OffsetExistingChildResourceMeshEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffsetExistingChildResourceMeshEventParams>.NativeClassPtr))
	{
	}
}
