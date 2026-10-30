using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public sealed class OnScreenKeyInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_label;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiftLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyType;

	private static readonly System.IntPtr NativeFieldInfoPtr_input;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiftInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_flexibleWidth;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLabel_Public_String_LocalPlayer_Boolean_0;

	public unsafe string label
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_label);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_label)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string shiftLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppSystem.Nullable<InputAction> inputAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputAction);
			return new Il2CppSystem.Nullable<InputAction>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<InputAction>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputAction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nullable)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<InputAction>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe OnScreenKeyType keyType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyType);
			return *(OnScreenKeyType*)num;
		}
		set
		{
			*(OnScreenKeyType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyType)) = onScreenKeyType;
		}
	}

	public unsafe string input
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string shiftInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftInput);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftInput)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool flexibleWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flexibleWidth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flexibleWidth)) = flag;
		}
	}

	static OnScreenKeyInfo()
	{
		Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "OnScreenKeyInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr);
		NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr, "label");
		NativeFieldInfoPtr_shiftLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr, "shiftLabel");
		NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr, "inputAction");
		NativeFieldInfoPtr_keyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr, "keyType");
		NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr, "input");
		NativeFieldInfoPtr_shiftInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr, "shiftInput");
		NativeFieldInfoPtr_flexibleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr, "flexibleWidth");
		NativeMethodInfoPtr_GetLabel_Public_String_LocalPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr, 100667630);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 79828, RefRangeEnd = 79829, XrefRangeStart = 79824, XrefRangeEnd = 79828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLabel(LocalPlayer player, bool shiftInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shiftInput;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLabel_Public_String_LocalPlayer_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public OnScreenKeyInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public OnScreenKeyInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnScreenKeyInfo>.NativeClassPtr))
	{
	}
}
