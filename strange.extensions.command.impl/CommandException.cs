using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using strange.extensions.command.api;

namespace strange.extensions.command.impl;

public class CommandException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeFieldInfoPtr__type_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_CommandExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_CommandExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_CommandExceptionType_0;

	public unsafe CommandExceptionType _type_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_k__BackingField);
			return *(CommandExceptionType*)num;
		}
		set
		{
			*(CommandExceptionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_k__BackingField)) = commandExceptionType;
		}
	}

	public unsafe CommandExceptionType type
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 277381, RefRangeEnd = 277393, XrefRangeStart = 277381, XrefRangeEnd = 277393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_CommandExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(CommandExceptionType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_type_Public_set_Void_CommandExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static CommandException()
	{
		Il2CppClassPointerStore<CommandException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.command.impl", "CommandException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandException>.NativeClassPtr);
		NativeFieldInfoPtr__type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandException>.NativeClassPtr, "<type>k__BackingField");
		NativeMethodInfoPtr_get_type_Public_get_CommandExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandException>.NativeClassPtr, 100685211);
		NativeMethodInfoPtr_set_type_Public_set_Void_CommandExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandException>.NativeClassPtr, 100685212);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandException>.NativeClassPtr, 100685213);
		NativeMethodInfoPtr__ctor_Public_Void_String_CommandExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandException>.NativeClassPtr, 100685214);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282288, XrefRangeEnd = 282292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CommandException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282292, XrefRangeEnd = 282296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CommandException(string message, CommandExceptionType exceptionType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(CommandExceptionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_CommandExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CommandException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
