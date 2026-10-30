using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.AI;

public class NavMeshAgentPool : BasePool<NavMeshAgent>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_NavMeshAgent_0;

	private static readonly IntPtr NativeMethodInfoPtr_onRelease_Private_Void_NavMeshAgent_0;

	private static readonly IntPtr NativeMethodInfoPtr_onDestroy_Private_Void_NavMeshAgent_0;

	static NavMeshAgentPool()
	{
		Il2CppClassPointerStore<NavMeshAgentPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NavMeshAgentPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavMeshAgentPool>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshAgentPool>.NativeClassPtr, 100664500);
		NativeMethodInfoPtr_onCreate_Private_NavMeshAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshAgentPool>.NativeClassPtr, 100664501);
		NativeMethodInfoPtr_onRelease_Private_Void_NavMeshAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshAgentPool>.NativeClassPtr, 100664502);
		NativeMethodInfoPtr_onDestroy_Private_Void_NavMeshAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshAgentPool>.NativeClassPtr, 100664503);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31196, XrefRangeEnd = 31224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NavMeshAgentPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavMeshAgentPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31224, XrefRangeEnd = 31235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NavMeshAgent onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_NavMeshAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NavMeshAgent>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31235, XrefRangeEnd = 31238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onRelease(NavMeshAgent navMeshAgent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)navMeshAgent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onRelease_Private_Void_NavMeshAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31238, XrefRangeEnd = 31244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onDestroy(NavMeshAgent navMeshAgent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)navMeshAgent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onDestroy_Private_Void_NavMeshAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NavMeshAgentPool(IntPtr pointer)
		: base(pointer)
	{
	}
}
