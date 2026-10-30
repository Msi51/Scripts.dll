using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class ControlSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_configurableKeyboardMouseInputActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_configurableGamepadInputActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_configurableKeyboardMouseInputActionSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_configurableGamepadInputActionSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerMovementStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerOrientationStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerInteractionStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerAttackStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_perspective;

	private static readonly System.IntPtr NativeFieldInfoPtr_invertMouseY;

	private static readonly System.IntPtr NativeFieldInfoPtr_macExternalKeyboardLayout;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_gamepadLookSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_gamepadGlyphs;

	private static readonly System.IntPtr NativeFieldInfoPtr_toggleRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_toggleShowItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyboardMouseControls;

	private static readonly System.IntPtr NativeFieldInfoPtr_gamepadControls;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigurableKeyboardMouseMappings_Public_get_Dictionary_2_InputAction_ControlMapping_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigurableGamepadMappings_Public_get_Dictionary_2_InputAction_ControlMapping_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaults_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ControlSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static List<InputAction> configurableKeyboardMouseInputActions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_configurableKeyboardMouseInputActions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InputAction>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_configurableKeyboardMouseInputActions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<InputAction> configurableGamepadInputActions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_configurableGamepadInputActions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InputAction>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_configurableGamepadInputActions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static HashSet<InputAction> configurableKeyboardMouseInputActionSet
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_configurableKeyboardMouseInputActionSet, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InputAction>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_configurableKeyboardMouseInputActionSet, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static HashSet<InputAction> configurableGamepadInputActionSet
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_configurableGamepadInputActionSet, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InputAction>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_configurableGamepadInputActionSet, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe int playerMovementStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMovementStyle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMovementStyle)) = num;
		}
	}

	public unsafe int playerOrientationStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerOrientationStyle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerOrientationStyle)) = num;
		}
	}

	public unsafe int playerInteractionStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerInteractionStyle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerInteractionStyle)) = num;
		}
	}

	public unsafe int playerAttackStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAttackStyle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAttackStyle)) = num;
		}
	}

	public unsafe int perspective
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perspective);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perspective)) = num;
		}
	}

	public unsafe bool invertMouseY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertMouseY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertMouseY)) = flag;
		}
	}

	public unsafe bool macExternalKeyboardLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_macExternalKeyboardLayout);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_macExternalKeyboardLayout)) = flag;
		}
	}

	public unsafe float rotationSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationSensitivity)) = num;
		}
	}

	public unsafe float gamepadLookSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadLookSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadLookSensitivity)) = num;
		}
	}

	public unsafe int gamepadGlyphs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadGlyphs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadGlyphs)) = num;
		}
	}

	public unsafe bool toggleRun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggleRun);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggleRun)) = flag;
		}
	}

	public unsafe bool toggleShowItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggleShowItems);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggleShowItems)) = flag;
		}
	}

	public unsafe Controls keyboardMouseControls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyboardMouseControls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controls>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyboardMouseControls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controls));
		}
	}

	public unsafe Controls gamepadControls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadControls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controls>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadControls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controls));
		}
	}

	public unsafe Dictionary<InputAction, ControlMapping> ConfigurableKeyboardMouseMappings
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19690, RefRangeEnd = 19692, XrefRangeStart = 19660, XrefRangeEnd = 19690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConfigurableKeyboardMouseMappings_Public_get_Dictionary_2_InputAction_ControlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InputAction, ControlMapping>>(intPtr) : null;
		}
	}

	public unsafe Dictionary<InputAction, ControlMapping> ConfigurableGamepadMappings
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19722, RefRangeEnd = 19724, XrefRangeStart = 19692, XrefRangeEnd = 19722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConfigurableGamepadMappings_Public_get_Dictionary_2_InputAction_ControlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InputAction, ControlMapping>>(intPtr) : null;
		}
	}

	static ControlSettings()
	{
		Il2CppClassPointerStore<ControlSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ControlSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr);
		NativeFieldInfoPtr_configurableKeyboardMouseInputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "configurableKeyboardMouseInputActions");
		NativeFieldInfoPtr_configurableGamepadInputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "configurableGamepadInputActions");
		NativeFieldInfoPtr_configurableKeyboardMouseInputActionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "configurableKeyboardMouseInputActionSet");
		NativeFieldInfoPtr_configurableGamepadInputActionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "configurableGamepadInputActionSet");
		NativeFieldInfoPtr_playerMovementStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "playerMovementStyle");
		NativeFieldInfoPtr_playerOrientationStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "playerOrientationStyle");
		NativeFieldInfoPtr_playerInteractionStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "playerInteractionStyle");
		NativeFieldInfoPtr_playerAttackStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "playerAttackStyle");
		NativeFieldInfoPtr_perspective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "perspective");
		NativeFieldInfoPtr_invertMouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "invertMouseY");
		NativeFieldInfoPtr_macExternalKeyboardLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "macExternalKeyboardLayout");
		NativeFieldInfoPtr_rotationSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "rotationSensitivity");
		NativeFieldInfoPtr_gamepadLookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "gamepadLookSensitivity");
		NativeFieldInfoPtr_gamepadGlyphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "gamepadGlyphs");
		NativeFieldInfoPtr_toggleRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "toggleRun");
		NativeFieldInfoPtr_toggleShowItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "toggleShowItems");
		NativeFieldInfoPtr_keyboardMouseControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "keyboardMouseControls");
		NativeFieldInfoPtr_gamepadControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, "gamepadControls");
		NativeMethodInfoPtr_get_ConfigurableKeyboardMouseMappings_Public_get_Dictionary_2_InputAction_ControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_get_ConfigurableGamepadMappings_Public_get_Dictionary_2_InputAction_ControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_SetDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_Equals_Public_Boolean_ControlSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr, 100663611);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 19724, RefRangeEnd = 19725, XrefRangeStart = 19724, XrefRangeEnd = 19724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 19871, RefRangeEnd = 19872, XrefRangeStart = 19725, XrefRangeEnd = 19871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 19965, RefRangeEnd = 19966, XrefRangeStart = 19872, XrefRangeEnd = 19965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Dictionary<string, Il2CppSystem.Object> MapToDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 20020, RefRangeEnd = 20025, XrefRangeStart = 19966, XrefRangeEnd = 20020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(ControlSettings other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_ControlSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20041, RefRangeEnd = 20042, XrefRangeStart = 20025, XrefRangeEnd = 20041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ControlSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
