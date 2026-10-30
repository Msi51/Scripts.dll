using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IHostility : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_IsHostileTo_Public_Abstract_Virtual_New_Boolean_Affiliation_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsHostileTo_Public_Abstract_Virtual_New_Boolean_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddHostility_Public_Abstract_Virtual_New_Void_Affiliation_0;

	static IHostility()
	{
		Il2CppClassPointerStore<IHostility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IHostility");
		NativeMethodInfoPtr_IsHostileTo_Public_Abstract_Virtual_New_Boolean_Affiliation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHostility>.NativeClassPtr, 100681601);
		NativeMethodInfoPtr_IsHostileTo_Public_Abstract_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHostility>.NativeClassPtr, 100681602);
		NativeMethodInfoPtr_AddHostility_Public_Abstract_Virtual_New_Void_Affiliation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHostility>.NativeClassPtr, 100681603);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsHostileTo(Affiliation affiliation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&affiliation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsHostileTo_Public_Abstract_Virtual_New_Boolean_Affiliation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsHostileTo(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsHostileTo_Public_Abstract_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void AddHostility(Affiliation affiliation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&affiliation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddHostility_Public_Abstract_Virtual_New_Void_Affiliation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IHostility(IntPtr pointer)
		: base(pointer)
	{
	}
}
