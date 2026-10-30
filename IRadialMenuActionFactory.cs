using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

public class IRadialMenuActionFactory : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_GetRadialMenuAction_Public_Abstract_Virtual_New_T_RadialMenuUI_LocalPlayer_Action_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetRadialMenuAction_Public_Abstract_Virtual_New_T_RadialMenuUI_LocalPlayer_Action_0, Il2CppClassPointerStore<IRadialMenuActionFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRadialMenuAction_Public_Abstract_Virtual_New_IRadialMenuItemAction_RadialMenuActionType_RadialMenuUI_LocalPlayer_Il2CppReferenceArray_1_IQuickMenuActionOption_Action_1_UIComponent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRadialMenuAction_Public_Abstract_Virtual_New_T_RadialMenuUI_LocalPlayer_Action_0;

	static IRadialMenuActionFactory()
	{
		Il2CppClassPointerStore<IRadialMenuActionFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IRadialMenuActionFactory");
		NativeMethodInfoPtr_GetRadialMenuAction_Public_Abstract_Virtual_New_IRadialMenuItemAction_RadialMenuActionType_RadialMenuUI_LocalPlayer_Il2CppReferenceArray_1_IQuickMenuActionOption_Action_1_UIComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRadialMenuActionFactory>.NativeClassPtr, 100669858);
		NativeMethodInfoPtr_GetRadialMenuAction_Public_Abstract_Virtual_New_T_RadialMenuUI_LocalPlayer_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRadialMenuActionFactory>.NativeClassPtr, 100669859);
	}

	[CallerCount(0)]
	public unsafe virtual IRadialMenuItemAction GetRadialMenuAction(RadialMenuActionType type, RadialMenuUI radialMenuUI, LocalPlayer player, Il2CppReferenceArray<IQuickMenuActionOption> options = null, Il2CppSystem.Action<UIComponent> action = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)radialMenuUI);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRadialMenuAction_Public_Abstract_Virtual_New_IRadialMenuItemAction_RadialMenuActionType_RadialMenuUI_LocalPlayer_Il2CppReferenceArray_1_IQuickMenuActionOption_Action_1_UIComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IRadialMenuItemAction>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual T GetRadialMenuAction<T>(RadialMenuUI radialMenuUI, LocalPlayer player, Il2CppSystem.Action onSelected = null) where T : class
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)radialMenuUI);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onSelected);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_GetRadialMenuAction_Public_Abstract_Virtual_New_T_RadialMenuUI_LocalPlayer_Action_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	public IRadialMenuActionFactory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
