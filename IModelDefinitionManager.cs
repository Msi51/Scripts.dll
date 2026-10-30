using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class IModelDefinitionManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_LoadDefinitions_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDefinitionsByType_Public_Abstract_Virtual_New_Dictionary_2_String_ModelDefinition_ModelDefinitionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetModelDefinition_Public_Abstract_Virtual_New_ModelDefinition_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_RegisterModel_Public_Abstract_Virtual_New_Void_String_Model_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetModel_Public_Abstract_Virtual_New_Model_String_0;

	static IModelDefinitionManager()
	{
		Il2CppClassPointerStore<IModelDefinitionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IModelDefinitionManager");
		NativeMethodInfoPtr_LoadDefinitions_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModelDefinitionManager>.NativeClassPtr, 100675529);
		NativeMethodInfoPtr_GetDefinitionsByType_Public_Abstract_Virtual_New_Dictionary_2_String_ModelDefinition_ModelDefinitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModelDefinitionManager>.NativeClassPtr, 100675530);
		NativeMethodInfoPtr_GetModelDefinition_Public_Abstract_Virtual_New_ModelDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModelDefinitionManager>.NativeClassPtr, 100675531);
		NativeMethodInfoPtr_RegisterModel_Public_Abstract_Virtual_New_Void_String_Model_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModelDefinitionManager>.NativeClassPtr, 100675532);
		NativeMethodInfoPtr_GetModel_Public_Abstract_Virtual_New_Model_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModelDefinitionManager>.NativeClassPtr, 100675533);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator LoadDefinitions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadDefinitions_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Dictionary<string, ModelDefinition> GetDefinitionsByType(ModelDefinitionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDefinitionsByType_Public_Abstract_Virtual_New_Dictionary_2_String_ModelDefinition_ModelDefinitionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, ModelDefinition>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ModelDefinition GetModelDefinition(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetModelDefinition_Public_Abstract_Virtual_New_ModelDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ModelDefinition>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void RegisterModel(string identifier, Model model)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RegisterModel_Public_Abstract_Virtual_New_Void_String_Model_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Model GetModel(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetModel_Public_Abstract_Virtual_New_Model_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
	}

	public IModelDefinitionManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
