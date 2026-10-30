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

public sealed class UpdateBuildingSectionMessage : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<UpdateBuildingSectionMessage>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingSectionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingSection;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BuildingSection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe int buildingSectionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingSectionId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingSectionId)) = num;
		}
	}

	public unsafe BuildingSection buildingSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuildingSection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildingSection));
		}
	}

	static UpdateBuildingSectionMessage()
	{
		Il2CppClassPointerStore<UpdateBuildingSectionMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "UpdateBuildingSectionMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateBuildingSectionMessage>.NativeClassPtr);
		NativeFieldInfoPtr_buildingSectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateBuildingSectionMessage>.NativeClassPtr, "buildingSectionId");
		NativeFieldInfoPtr_buildingSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateBuildingSectionMessage>.NativeClassPtr, "buildingSection");
		NativeMethodInfoPtr__ctor_Public_Void_BuildingSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateBuildingSectionMessage>.NativeClassPtr, 100664200);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateBuildingSectionMessage>.NativeClassPtr, 100664201);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28017, RefRangeEnd = 28018, XrefRangeStart = 28015, XrefRangeEnd = 28017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UpdateBuildingSectionMessage(BuildingSection buildingSection)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateBuildingSectionMessage>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildingSection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BuildingSection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28018, XrefRangeEnd = 28032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UpdateBuildingSectionMessage(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public UpdateBuildingSectionMessage()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateBuildingSectionMessage>.NativeClassPtr))
	{
	}
}
