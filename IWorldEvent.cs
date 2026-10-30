using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IWorldEvent : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetWorldEventType_Public_Abstract_Virtual_New_WorldEventType_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Boolean_World_0;

	static IWorldEvent()
	{
		Il2CppClassPointerStore<IWorldEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IWorldEvent");
		NativeMethodInfoPtr_GetWorldEventType_Public_Abstract_Virtual_New_WorldEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldEvent>.NativeClassPtr, 100683687);
		NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldEvent>.NativeClassPtr, 100683688);
	}

	[CallerCount(0)]
	public unsafe virtual WorldEventType GetWorldEventType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWorldEventType_Public_Abstract_Virtual_New_WorldEventType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(WorldEventType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Execute(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Boolean_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IWorldEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
