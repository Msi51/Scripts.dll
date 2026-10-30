using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class IStatusEffectManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_InitializeStatusEffects_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStatusEffectDefinitionMap_Public_Abstract_Virtual_New_Dictionary_2_String_StatusEffectDefinition_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStatusEffectDefinitions_Public_Abstract_Virtual_New_ValueCollection_String_StatusEffectDefinition_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStatusEffectDefinition_Public_Abstract_Virtual_New_StatusEffectDefinition_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStatusEffectDefinition_Public_Abstract_Virtual_New_StatusEffectDefinition_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDisplayProperties_Public_Abstract_Virtual_New_List_1_ModelDisplayProperty_0;

	static IStatusEffectManager()
	{
		Il2CppClassPointerStore<IStatusEffectManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IStatusEffectManager");
		NativeMethodInfoPtr_InitializeStatusEffects_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffectManager>.NativeClassPtr, 100675895);
		NativeMethodInfoPtr_GetStatusEffectDefinitionMap_Public_Abstract_Virtual_New_Dictionary_2_String_StatusEffectDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffectManager>.NativeClassPtr, 100675896);
		NativeMethodInfoPtr_GetStatusEffectDefinitions_Public_Abstract_Virtual_New_ValueCollection_String_StatusEffectDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffectManager>.NativeClassPtr, 100675897);
		NativeMethodInfoPtr_GetStatusEffectDefinition_Public_Abstract_Virtual_New_StatusEffectDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffectManager>.NativeClassPtr, 100675898);
		NativeMethodInfoPtr_GetStatusEffectDefinition_Public_Abstract_Virtual_New_StatusEffectDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffectManager>.NativeClassPtr, 100675899);
		NativeMethodInfoPtr_GetDisplayProperties_Public_Abstract_Virtual_New_List_1_ModelDisplayProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffectManager>.NativeClassPtr, 100675900);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator InitializeStatusEffects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeStatusEffects_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Dictionary<string, StatusEffectDefinition> GetStatusEffectDefinitionMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStatusEffectDefinitionMap_Public_Abstract_Virtual_New_Dictionary_2_String_StatusEffectDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, StatusEffectDefinition>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Dictionary<string, StatusEffectDefinition>.ValueCollection GetStatusEffectDefinitions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStatusEffectDefinitions_Public_Abstract_Virtual_New_ValueCollection_String_StatusEffectDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, StatusEffectDefinition>.ValueCollection>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual StatusEffectDefinition GetStatusEffectDefinition(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStatusEffectDefinition_Public_Abstract_Virtual_New_StatusEffectDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StatusEffectDefinition>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual StatusEffectDefinition GetStatusEffectDefinition(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStatusEffectDefinition_Public_Abstract_Virtual_New_StatusEffectDefinition_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StatusEffectDefinition>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual List<ModelDisplayProperty> GetDisplayProperties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDisplayProperties_Public_Abstract_Virtual_New_List_1_ModelDisplayProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ModelDisplayProperty>>(intPtr) : null;
	}

	public IStatusEffectManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
