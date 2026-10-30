using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

public class IComponentUpdateListener<TUpdate> : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_HandleUpdate_Public_Abstract_Virtual_New_Void_byref_TUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUpdateListenerActive_Public_Abstract_Virtual_New_Boolean_0;

	static IComponentUpdateListener()
	{
		Il2CppClassPointerStore<IComponentUpdateListener<TUpdate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Scripts.dll", "", "IComponentUpdateListener`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TUpdate>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr_HandleUpdate_Public_Abstract_Virtual_New_Void_byref_TUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentUpdateListener<TUpdate>>.NativeClassPtr, 100663788);
		NativeMethodInfoPtr_IsUpdateListenerActive_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentUpdateListener<TUpdate>>.NativeClassPtr, 100663789);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleUpdate(ref TUpdate update)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TUpdate, object>(ref update));
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleUpdate_Public_Abstract_Virtual_New_Void_byref_TUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TUpdate, object>(ref update) = ((intPtr4 == (System.IntPtr)0) ? ((TUpdate)null) : IL2CPP.PointerToValueGeneric<TUpdate>(intPtr4, false, false));
	}

	[CallerCount(0)]
	public unsafe virtual bool IsUpdateListenerActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsUpdateListenerActive_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IComponentUpdateListener(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
