using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

public class IEntityDefinition : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_GetValue_Public_Abstract_Virtual_New_T_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_T_String_0, Il2CppClassPointerStore<IEntityDefinition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIdentifier_Public_Abstract_Virtual_New_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_T_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEntityDefinition_Public_Abstract_Virtual_New_Void_ModelDefinition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityDefinitionType_Public_Abstract_Virtual_New_ModelDefinitionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityDefinition_Public_Abstract_Virtual_New_ModelDefinition_0;

	static IEntityDefinition()
	{
		Il2CppClassPointerStore<IEntityDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IEntityDefinition");
		NativeMethodInfoPtr_GetIdentifier_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityDefinition>.NativeClassPtr, 100681443);
		NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityDefinition>.NativeClassPtr, 100681444);
		NativeMethodInfoPtr_SetEntityDefinition_Public_Abstract_Virtual_New_Void_ModelDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityDefinition>.NativeClassPtr, 100681445);
		NativeMethodInfoPtr_GetEntityDefinitionType_Public_Abstract_Virtual_New_ModelDefinitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityDefinition>.NativeClassPtr, 100681446);
		NativeMethodInfoPtr_GetEntityDefinition_Public_Abstract_Virtual_New_ModelDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityDefinition>.NativeClassPtr, 100681447);
	}

	[CallerCount(0)]
	public unsafe virtual string GetIdentifier()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetIdentifier_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual T GetValue<T>(string fieldName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_GetValue_Public_Abstract_Virtual_New_T_String_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(0)]
	public unsafe virtual void SetEntityDefinition(ModelDefinition definition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)definition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetEntityDefinition_Public_Abstract_Virtual_New_Void_ModelDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual ModelDefinitionType GetEntityDefinitionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEntityDefinitionType_Public_Abstract_Virtual_New_ModelDefinitionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ModelDefinitionType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual ModelDefinition GetEntityDefinition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEntityDefinition_Public_Abstract_Virtual_New_ModelDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModelDefinition>(intPtr) : null;
	}

	public IEntityDefinition(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
