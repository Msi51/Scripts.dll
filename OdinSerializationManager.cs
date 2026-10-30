using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using OdinSerializer;

public class OdinSerializationManager : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_Deserialize_Public_Virtual_Final_New_T_Stream_PersistenceFormat_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_T_Stream_PersistenceFormat_0, Il2CppClassPointerStore<OdinSerializationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_T_Stream_PersistenceFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Object_Stream_PersistenceFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDataFormat_Private_DataFormat_PersistenceFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static OdinSerializationManager()
	{
		Il2CppClassPointerStore<OdinSerializationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "OdinSerializationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OdinSerializationManager>.NativeClassPtr);
		NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_T_Stream_PersistenceFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OdinSerializationManager>.NativeClassPtr, 100676638);
		NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Object_Stream_PersistenceFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OdinSerializationManager>.NativeClassPtr, 100676639);
		NativeMethodInfoPtr_getDataFormat_Private_DataFormat_PersistenceFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OdinSerializationManager>.NativeClassPtr, 100676640);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OdinSerializationManager>.NativeClassPtr, 100676641);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187029, XrefRangeEnd = 187030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual T Deserialize<T>(Stream stream, PersistenceFormat format) where T : class
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		*(PersistenceFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Deserialize_Public_Virtual_Final_New_T_Stream_PersistenceFormat_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187030, XrefRangeEnd = 187033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Serialize(Il2CppSystem.Object obj, Stream stream, PersistenceFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		*(PersistenceFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Object_Stream_PersistenceFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187033, RefRangeEnd = 187034, XrefRangeStart = 187033, XrefRangeEnd = 187033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataFormat getDataFormat(PersistenceFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDataFormat_Private_DataFormat_PersistenceFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DataFormat*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OdinSerializationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OdinSerializationManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OdinSerializationManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
