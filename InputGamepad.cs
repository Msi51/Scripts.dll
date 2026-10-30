using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class InputGamepad : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_identifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_control;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_directionSpriteValue;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Dictionary_2_GamepadType_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSprite_Public_String_GamepadType_0;

	public unsafe string identifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string control
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_control);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_control)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Dictionary<GamepadType, string> spriteNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GamepadType, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe string directionSpriteValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directionSpriteValue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directionSpriteValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static InputGamepad()
	{
		Il2CppClassPointerStore<InputGamepad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InputGamepad");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputGamepad>.NativeClassPtr);
		NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputGamepad>.NativeClassPtr, "identifier");
		NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputGamepad>.NativeClassPtr, "control");
		NativeFieldInfoPtr_spriteNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputGamepad>.NativeClassPtr, "spriteNames");
		NativeFieldInfoPtr_directionSpriteValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputGamepad>.NativeClassPtr, "directionSpriteValue");
		NativeMethodInfoPtr__ctor_Public_Void_String_String_Dictionary_2_GamepadType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGamepad>.NativeClassPtr, 100663694);
		NativeMethodInfoPtr_GetSprite_Public_String_GamepadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGamepad>.NativeClassPtr, 100663695);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 22165, RefRangeEnd = 22189, XrefRangeStart = 22151, XrefRangeEnd = 22165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputGamepad(string identifier, string control, Dictionary<GamepadType, string> spriteNames, string directionSprite = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputGamepad>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(directionSprite);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_Dictionary_2_GamepadType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22199, RefRangeEnd = 22201, XrefRangeStart = 22189, XrefRangeEnd = 22199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSprite(GamepadType gamepadType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gamepadType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSprite_Public_String_GamepadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public InputGamepad(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
