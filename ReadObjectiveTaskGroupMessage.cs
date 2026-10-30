using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;

public sealed class ReadObjectiveTaskGroupMessage : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<ReadObjectiveTaskGroupMessage>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_objectiveIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectiveTaskGroupIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetCharacterInstanceId;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectiveTaskGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe string objectiveIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string objectiveTaskGroupIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveTaskGroupIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveTaskGroupIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int targetCharacterInstanceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetCharacterInstanceId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetCharacterInstanceId)) = num;
		}
	}

	static ReadObjectiveTaskGroupMessage()
	{
		Il2CppClassPointerStore<ReadObjectiveTaskGroupMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ReadObjectiveTaskGroupMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadObjectiveTaskGroupMessage>.NativeClassPtr);
		NativeFieldInfoPtr_objectiveIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectiveTaskGroupMessage>.NativeClassPtr, "objectiveIdentifier");
		NativeFieldInfoPtr_objectiveTaskGroupIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectiveTaskGroupMessage>.NativeClassPtr, "objectiveTaskGroupIdentifier");
		NativeFieldInfoPtr_targetCharacterInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectiveTaskGroupMessage>.NativeClassPtr, "targetCharacterInstanceId");
		NativeMethodInfoPtr__ctor_Public_Void_ObjectiveTaskGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectiveTaskGroupMessage>.NativeClassPtr, 100664141);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectiveTaskGroupMessage>.NativeClassPtr, 100664142);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 27217, RefRangeEnd = 27218, XrefRangeStart = 27215, XrefRangeEnd = 27217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadObjectiveTaskGroupMessage(ObjectiveTaskGroup objectiveTaskGroup)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadObjectiveTaskGroupMessage>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ObjectiveTaskGroup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ReadObjectiveTaskGroupMessage(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ReadObjectiveTaskGroupMessage()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadObjectiveTaskGroupMessage>.NativeClassPtr))
	{
	}
}
