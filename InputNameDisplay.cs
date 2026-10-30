using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public sealed class InputNameDisplay : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_text;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteText;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputKey_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputAxis_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputGamepad_GamepadType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSprite_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_String_0;

	public unsafe string text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string spriteText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool Valid
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22406, RefRangeEnd = 22407, XrefRangeStart = 22406, XrefRangeEnd = 22406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static InputNameDisplay()
	{
		Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InputNameDisplay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr);
		NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr, "text");
		NativeFieldInfoPtr_spriteText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr, "spriteText");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr, 100663699);
		NativeMethodInfoPtr__ctor_Public_Void_InputKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr, 100663700);
		NativeMethodInfoPtr__ctor_Public_Void_InputAxis_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr, 100663701);
		NativeMethodInfoPtr__ctor_Public_Void_InputGamepad_GamepadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr, 100663702);
		NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr, 100663703);
		NativeMethodInfoPtr_IsSprite_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr, 100663704);
		NativeMethodInfoPtr_GetValue_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr, 100663705);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22358, RefRangeEnd = 22359, XrefRangeStart = 22356, XrefRangeEnd = 22358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputNameDisplay(string text)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22371, RefRangeEnd = 22373, XrefRangeStart = 22359, XrefRangeEnd = 22371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputNameDisplay(InputKey inputKey, bool shortVersion)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputKey);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortVersion;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InputKey_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22385, RefRangeEnd = 22387, XrefRangeStart = 22373, XrefRangeEnd = 22385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputNameDisplay(InputAxis inputAxis, bool shortVersion)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputAxis);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortVersion;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InputAxis_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 22403, RefRangeEnd = 22406, XrefRangeStart = 22387, XrefRangeEnd = 22403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputNameDisplay(InputGamepad inputGamepad, GamepadType gamepadType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputGamepad);
		*(GamepadType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gamepadType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InputGamepad_GamepadType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22407, RefRangeEnd = 22409, XrefRangeStart = 22407, XrefRangeEnd = 22407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSprite()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSprite_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 22409, RefRangeEnd = 22414, XrefRangeStart = 22409, XrefRangeEnd = 22409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public InputNameDisplay(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InputNameDisplay()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputNameDisplay>.NativeClassPtr))
	{
	}
}
