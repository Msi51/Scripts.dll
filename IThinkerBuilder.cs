using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IThinkerBuilder : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Abstract_Virtual_New_Boolean_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_AIThinker_Entity_0;

	static IThinkerBuilder()
	{
		Il2CppClassPointerStore<IThinkerBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IThinkerBuilder");
		NativeMethodInfoPtr_Matches_Public_Abstract_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IThinkerBuilder>.NativeClassPtr, 100668558);
		NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_AIThinker_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IThinkerBuilder>.NativeClassPtr, 100668559);
	}

	[CallerCount(0)]
	public unsafe virtual bool Matches(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Matches_Public_Abstract_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual AIThinker Build(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_AIThinker_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIThinker>(intPtr) : null;
	}

	public IThinkerBuilder(IntPtr pointer)
		: base(pointer)
	{
	}
}
