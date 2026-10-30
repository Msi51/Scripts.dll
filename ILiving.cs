using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ILiving : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetAffiliation_Public_Abstract_Virtual_New_Affiliation_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetAffiliation_Public_Abstract_Virtual_New_Void_Affiliation_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Abstract_Virtual_New_LivingEntityState_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsDead_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Abstract_Virtual_New_Void_LivingEntityState_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDeathTime_Public_Abstract_Virtual_New_Single_0;

	static ILiving()
	{
		Il2CppClassPointerStore<ILiving>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ILiving");
		NativeMethodInfoPtr_GetAffiliation_Public_Abstract_Virtual_New_Affiliation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILiving>.NativeClassPtr, 100681759);
		NativeMethodInfoPtr_SetAffiliation_Public_Abstract_Virtual_New_Void_Affiliation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILiving>.NativeClassPtr, 100681760);
		NativeMethodInfoPtr_GetState_Public_Abstract_Virtual_New_LivingEntityState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILiving>.NativeClassPtr, 100681761);
		NativeMethodInfoPtr_IsDead_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILiving>.NativeClassPtr, 100681762);
		NativeMethodInfoPtr_SetState_Public_Abstract_Virtual_New_Void_LivingEntityState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILiving>.NativeClassPtr, 100681763);
		NativeMethodInfoPtr_GetDeathTime_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILiving>.NativeClassPtr, 100681764);
	}

	[CallerCount(0)]
	public unsafe virtual Affiliation GetAffiliation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAffiliation_Public_Abstract_Virtual_New_Affiliation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Affiliation*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetAffiliation(Affiliation affiliation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&affiliation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetAffiliation_Public_Abstract_Virtual_New_Void_Affiliation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual LivingEntityState GetState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetState_Public_Abstract_Virtual_New_LivingEntityState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(LivingEntityState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsDead()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsDead_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetState(LivingEntityState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetState_Public_Abstract_Virtual_New_Void_LivingEntityState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual float GetDeathTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDeathTime_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ILiving(IntPtr pointer)
		: base(pointer)
	{
	}
}
