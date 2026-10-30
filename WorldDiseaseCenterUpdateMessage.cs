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

public sealed class WorldDiseaseCenterUpdateMessage : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<WorldDiseaseCenterUpdateMessage>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_update;

	private static readonly System.IntPtr NativeFieldInfoPtr_world;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkWorldDiseaseCenterUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe World.NetworkWorldDiseaseCenterUpdate update
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_update);
			return new World.NetworkWorldDiseaseCenterUpdate(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<World.NetworkWorldDiseaseCenterUpdate>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_update), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkWorldDiseaseCenterUpdate)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<World.NetworkWorldDiseaseCenterUpdate>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe World world
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
		}
	}

	static WorldDiseaseCenterUpdateMessage()
	{
		Il2CppClassPointerStore<WorldDiseaseCenterUpdateMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WorldDiseaseCenterUpdateMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldDiseaseCenterUpdateMessage>.NativeClassPtr);
		NativeFieldInfoPtr_update = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldDiseaseCenterUpdateMessage>.NativeClassPtr, "update");
		NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldDiseaseCenterUpdateMessage>.NativeClassPtr, "world");
		NativeMethodInfoPtr__ctor_Public_Void_NetworkWorldDiseaseCenterUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldDiseaseCenterUpdateMessage>.NativeClassPtr, 100664215);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldDiseaseCenterUpdateMessage>.NativeClassPtr, 100664216);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 28214, RefRangeEnd = 28216, XrefRangeStart = 28212, XrefRangeEnd = 28214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldDiseaseCenterUpdateMessage(World.NetworkWorldDiseaseCenterUpdate update)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldDiseaseCenterUpdateMessage>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkWorldDiseaseCenterUpdate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28216, XrefRangeEnd = 28217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldDiseaseCenterUpdateMessage(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public WorldDiseaseCenterUpdateMessage()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldDiseaseCenterUpdateMessage>.NativeClassPtr))
	{
	}
}
