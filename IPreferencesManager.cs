using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

public class IPreferencesManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_SaveLastAdvancedGameOptions_Public_Abstract_Virtual_New_Void_AdvancedGameOptions_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetGamePreferences_Public_Abstract_Virtual_New_GamePreferences_0;

	static IPreferencesManager()
	{
		Il2CppClassPointerStore<IPreferencesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IPreferencesManager");
		NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPreferencesManager>.NativeClassPtr, 100675734);
		NativeMethodInfoPtr_SaveLastAdvancedGameOptions_Public_Abstract_Virtual_New_Void_AdvancedGameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPreferencesManager>.NativeClassPtr, 100675735);
		NativeMethodInfoPtr_GetGamePreferences_Public_Abstract_Virtual_New_GamePreferences_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPreferencesManager>.NativeClassPtr, 100675736);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SaveLastAdvancedGameOptions(AdvancedGameOptions advancedGameOptions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)advancedGameOptions);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveLastAdvancedGameOptions_Public_Abstract_Virtual_New_Void_AdvancedGameOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual GamePreferences GetGamePreferences()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetGamePreferences_Public_Abstract_Virtual_New_GamePreferences_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GamePreferences>(intPtr) : null;
	}

	public IPreferencesManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
