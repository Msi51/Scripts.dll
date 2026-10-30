using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ISurvivalSceneManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_LoadDemoScene_Public_Abstract_Virtual_New_Void_LoadGameSceneCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadMenuScene_Public_Abstract_Virtual_New_Void_LoadGameSceneCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsMenuSceneLoaded_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnloadToRootScene_Public_Abstract_Virtual_New_Void_UnloadToRootSceneCallback_0;

	static ISurvivalSceneManager()
	{
		Il2CppClassPointerStore<ISurvivalSceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISurvivalSceneManager");
		NativeMethodInfoPtr_LoadDemoScene_Public_Abstract_Virtual_New_Void_LoadGameSceneCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurvivalSceneManager>.NativeClassPtr, 100675948);
		NativeMethodInfoPtr_LoadMenuScene_Public_Abstract_Virtual_New_Void_LoadGameSceneCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurvivalSceneManager>.NativeClassPtr, 100675949);
		NativeMethodInfoPtr_IsMenuSceneLoaded_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurvivalSceneManager>.NativeClassPtr, 100675950);
		NativeMethodInfoPtr_UnloadToRootScene_Public_Abstract_Virtual_New_Void_UnloadToRootSceneCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurvivalSceneManager>.NativeClassPtr, 100675951);
	}

	[CallerCount(0)]
	public unsafe virtual void LoadDemoScene(LoadGameSceneCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadDemoScene_Public_Abstract_Virtual_New_Void_LoadGameSceneCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void LoadMenuScene(LoadGameSceneCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadMenuScene_Public_Abstract_Virtual_New_Void_LoadGameSceneCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsMenuSceneLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsMenuSceneLoaded_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UnloadToRootScene(UnloadToRootSceneCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UnloadToRootScene_Public_Abstract_Virtual_New_Void_UnloadToRootSceneCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ISurvivalSceneManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
