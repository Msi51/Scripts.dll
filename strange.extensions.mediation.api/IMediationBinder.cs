using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace strange.extensions.mediation.api;

public class IMediationBinder : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_Bind_Public_Abstract_Virtual_New_IMediationBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_IMediationBinding_0, Il2CppClassPointerStore<IMediationBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_BindView_Public_Abstract_Virtual_New_IMediationBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_BindView_Public_Abstract_Virtual_New_IMediationBinding_0, Il2CppClassPointerStore<IMediationBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Trigger_Public_Abstract_Virtual_New_Void_MediationEvent_IView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_IMediationBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindView_Public_Abstract_Virtual_New_IMediationBinding_0;

	static IMediationBinder()
	{
		Il2CppClassPointerStore<IMediationBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.mediation.api", "IMediationBinder");
		NativeMethodInfoPtr_Trigger_Public_Abstract_Virtual_New_Void_MediationEvent_IView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMediationBinder>.NativeClassPtr, 100684734);
		NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_IMediationBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMediationBinder>.NativeClassPtr, 100684735);
		NativeMethodInfoPtr_BindView_Public_Abstract_Virtual_New_IMediationBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMediationBinder>.NativeClassPtr, 100684736);
	}

	[CallerCount(0)]
	public unsafe virtual void Trigger(MediationEvent evt, IView view)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Trigger_Public_Abstract_Virtual_New_Void_MediationEvent_IView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual IMediationBinding Bind<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_Bind_Public_Abstract_Virtual_New_IMediationBinding_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMediationBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IMediationBinding BindView<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_BindView_Public_Abstract_Virtual_New_IMediationBinding_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMediationBinding>(intPtr) : null;
	}

	public IMediationBinder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
