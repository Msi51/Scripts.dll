using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

public static class SerializableFieldUtil : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_Initialize_Public_Static_Void_SerializationContext_byref_TField_String_SerializableFieldNetworkState_0<TField>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Initialize_Public_Static_Void_SerializationContext_byref_TField_String_SerializableFieldNetworkState_0, Il2CppClassPointerStore<SerializableFieldUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TField>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Initialize_Public_Static_Void_SerializationContext_byref_TField_String_TType_SerializableFieldNetworkState_0<TField, TType>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Initialize_Public_Static_Void_SerializationContext_byref_TField_String_TType_SerializableFieldNetworkState_0, Il2CppClassPointerStore<SerializableFieldUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TField>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_SerializationContext_byref_TField_String_SerializableFieldNetworkState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_SerializationContext_byref_TField_String_TType_SerializableFieldNetworkState_0;

	static SerializableFieldUtil()
	{
		Il2CppClassPointerStore<SerializableFieldUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SerializableFieldUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableFieldUtil>.NativeClassPtr);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_SerializationContext_byref_TField_String_SerializableFieldNetworkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableFieldUtil>.NativeClassPtr, 100667901);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_SerializationContext_byref_TField_String_TType_SerializableFieldNetworkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableFieldUtil>.NativeClassPtr, 100667902);
	}

	[CallerCount(759)]
	[CachedScanResults(RefRangeStart = 84662, RefRangeEnd = 85421, XrefRangeStart = 84652, XrefRangeEnd = 84662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize<TField>(SerializationContext context, ref TField field, string fieldName, SerializableFieldNetworkState networkState = default(SerializableFieldNetworkState)) where TField : SerializableField, new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
		*(SerializableFieldNetworkState**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &networkState;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Initialize_Public_Static_Void_SerializationContext_byref_TField_String_SerializableFieldNetworkState_0<TField>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		field = ((intPtr4 == (System.IntPtr)0) ? null : IL2CPP.PointerToValueGeneric<TField>(intPtr4, false, false));
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 85432, RefRangeEnd = 85441, XrefRangeStart = 85421, XrefRangeEnd = 85432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize<TField, TType>(SerializationContext context, ref TField field, string fieldName, TType defaultValue, SerializableFieldNetworkState networkState = default(SerializableFieldNetworkState)) where TField : BaseSerializableField<TType>, new()
	{
		//IL_0080->IL0083: Incompatible stack types: I vs Ref
		//IL_0073->IL0083: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TType reference;
		if (!typeof(TType).IsValueType)
		{
			object obj = defaultValue;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref defaultValue;
		}
		*(void**)num2 = Unsafe.AsPointer(ref reference);
		*(SerializableFieldNetworkState**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &networkState;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Initialize_Public_Static_Void_SerializationContext_byref_TField_String_TType_SerializableFieldNetworkState_0<TField, TType>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		field = ((intPtr4 == (System.IntPtr)0) ? null : IL2CPP.PointerToValueGeneric<TField>(intPtr4, false, false));
	}

	public SerializableFieldUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
