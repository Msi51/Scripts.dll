using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

public class ITaskManager : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_ScheduleTask_Public_Abstract_Virtual_New_Task_1_T_Func_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ScheduleTask_Public_Abstract_Virtual_New_Task_1_T_Func_1_T_0, Il2CppClassPointerStore<ITaskManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTask_Public_Abstract_Virtual_New_Task_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTask_Public_Abstract_Virtual_New_Task_1_T_Func_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Delay_Public_Abstract_Virtual_New_Task_Int32_0;

	static ITaskManager()
	{
		Il2CppClassPointerStore<ITaskManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ITaskManager");
		NativeMethodInfoPtr_ScheduleTask_Public_Abstract_Virtual_New_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITaskManager>.NativeClassPtr, 100675952);
		NativeMethodInfoPtr_ScheduleTask_Public_Abstract_Virtual_New_Task_1_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITaskManager>.NativeClassPtr, 100675953);
		NativeMethodInfoPtr_Delay_Public_Abstract_Virtual_New_Task_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITaskManager>.NativeClassPtr, 100675954);
	}

	[CallerCount(0)]
	public unsafe virtual Task ScheduleTask(Il2CppSystem.Action action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ScheduleTask_Public_Abstract_Virtual_New_Task_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task<T> ScheduleTask<T>(Il2CppSystem.Func<T> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_ScheduleTask_Public_Abstract_Virtual_New_Task_1_T_Func_1_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<T>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task Delay(int ms)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ms);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Delay_Public_Abstract_Virtual_New_Task_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	public ITaskManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
