using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;

public class ISerializationManager : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_Deserialize_Public_Abstract_Virtual_New_T_Stream_PersistenceFormat_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_T_Stream_PersistenceFormat_0, Il2CppClassPointerStore<ISerializationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_T_Stream_PersistenceFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_Object_Stream_PersistenceFormat_0;

	static ISerializationManager()
	{
		Il2CppClassPointerStore<ISerializationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISerializationManager");
		NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_T_Stream_PersistenceFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationManager>.NativeClassPtr, 100675774);
		NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_Object_Stream_PersistenceFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationManager>.NativeClassPtr, 100675775);
	}

	[CallerCount(0)]
	public unsafe virtual T Deserialize<T>(Stream stream, PersistenceFormat format) where T : class
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		*(PersistenceFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_Deserialize_Public_Abstract_Virtual_New_T_Stream_PersistenceFormat_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(0)]
	public unsafe virtual void Serialize(Il2CppSystem.Object obj, Stream stream, PersistenceFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		*(PersistenceFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_Object_Stream_PersistenceFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ISerializationManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
