using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

public class IComponentManager : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_AddComponentInitializer_Public_Abstract_Virtual_New_Void_Action_2_Entity_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddComponentInitializer_Public_Abstract_Virtual_New_Void_Action_2_Entity_T_0, Il2CppClassPointerStore<IComponentManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeComponents_Public_Abstract_Virtual_New_Void_Entity_List_1_BaseView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupEntityComponent_Public_Abstract_Virtual_New_Void_Entity_BaseView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityComponent_Public_Abstract_Virtual_New_IEntityComponent_BaseView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddComponentInitializer_Public_Abstract_Virtual_New_Void_Action_2_Entity_T_0;

	static IComponentManager()
	{
		Il2CppClassPointerStore<IComponentManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IComponentManager");
		NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentManager>.NativeClassPtr, 100675295);
		NativeMethodInfoPtr_InitializeComponents_Public_Abstract_Virtual_New_Void_Entity_List_1_BaseView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentManager>.NativeClassPtr, 100675296);
		NativeMethodInfoPtr_SetupEntityComponent_Public_Abstract_Virtual_New_Void_Entity_BaseView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentManager>.NativeClassPtr, 100675297);
		NativeMethodInfoPtr_GetEntityComponent_Public_Abstract_Virtual_New_IEntityComponent_BaseView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentManager>.NativeClassPtr, 100675298);
		NativeMethodInfoPtr_AddComponentInitializer_Public_Abstract_Virtual_New_Void_Action_2_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentManager>.NativeClassPtr, 100675299);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void InitializeComponents(Entity entity, List<BaseView> components)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)components);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeComponents_Public_Abstract_Virtual_New_Void_Entity_List_1_BaseView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetupEntityComponent(Entity entity, BaseView view)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetupEntityComponent_Public_Abstract_Virtual_New_Void_Entity_BaseView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual IEntityComponent GetEntityComponent(BaseView view)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEntityComponent_Public_Abstract_Virtual_New_IEntityComponent_BaseView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEntityComponent>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void AddComponentInitializer<T>(Il2CppSystem.Action<Entity, T> action) where T : class
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_AddComponentInitializer_Public_Abstract_Virtual_New_Void_Action_2_Entity_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IComponentManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
