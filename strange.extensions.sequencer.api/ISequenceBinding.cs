using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace strange.extensions.sequencer.api;

public class ISequenceBinding : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_Bind_Public_Abstract_Virtual_New_ISequenceBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_ISequenceBinding_0, Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_To_Public_Abstract_Virtual_New_ISequenceBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_ISequenceBinding_0, Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ToName_Public_Abstract_Virtual_New_ISequenceBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ToName_Public_Abstract_Virtual_New_ISequenceBinding_0, Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Named_Public_Abstract_Virtual_New_ISequenceBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Named_Public_Abstract_Virtual_New_ISequenceBinding_0, Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Once_Public_Abstract_Virtual_New_ISequenceBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isOneOff_Public_Abstract_Virtual_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isOneOff_Public_Abstract_Virtual_New_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_ISequenceBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_ISequenceBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_ISequenceBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_ISequenceBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToName_Public_Abstract_Virtual_New_ISequenceBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToName_Public_Abstract_Virtual_New_ISequenceBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Named_Public_Abstract_Virtual_New_ISequenceBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Named_Public_Abstract_Virtual_New_ISequenceBinding_Object_0;

	public unsafe virtual bool isOneOff
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_isOneOff_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_isOneOff_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ISequenceBinding()
	{
		Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.sequencer.api", "ISequenceBinding");
		NativeMethodInfoPtr_Once_Public_Abstract_Virtual_New_ISequenceBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684411);
		NativeMethodInfoPtr_get_isOneOff_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684412);
		NativeMethodInfoPtr_set_isOneOff_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684413);
		NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_ISequenceBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684414);
		NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_ISequenceBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684415);
		NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_ISequenceBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684416);
		NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_ISequenceBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684417);
		NativeMethodInfoPtr_ToName_Public_Abstract_Virtual_New_ISequenceBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684418);
		NativeMethodInfoPtr_ToName_Public_Abstract_Virtual_New_ISequenceBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684419);
		NativeMethodInfoPtr_Named_Public_Abstract_Virtual_New_ISequenceBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684420);
		NativeMethodInfoPtr_Named_Public_Abstract_Virtual_New_ISequenceBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBinding>.NativeClassPtr, 100684421);
	}

	[CallerCount(0)]
	public unsafe virtual ISequenceBinding Once()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Once_Public_Abstract_Virtual_New_ISequenceBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISequenceBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ISequenceBinding Bind<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_Bind_Public_Abstract_Virtual_New_ISequenceBinding_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISequenceBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ISequenceBinding Bind(Il2CppSystem.Object key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_ISequenceBinding_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISequenceBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ISequenceBinding To<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_To_Public_Abstract_Virtual_New_ISequenceBinding_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISequenceBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ISequenceBinding To(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_ISequenceBinding_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISequenceBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ISequenceBinding ToName<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_ToName_Public_Abstract_Virtual_New_ISequenceBinding_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISequenceBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ISequenceBinding ToName(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToName_Public_Abstract_Virtual_New_ISequenceBinding_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISequenceBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ISequenceBinding Named<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_Named_Public_Abstract_Virtual_New_ISequenceBinding_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISequenceBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ISequenceBinding Named(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Named_Public_Abstract_Virtual_New_ISequenceBinding_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISequenceBinding>(intPtr) : null;
	}

	public ISequenceBinding(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
