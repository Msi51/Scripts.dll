using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.injector.api;

public class ProjectileStickEventHandler : GameEventHandler<ProjectileStickEventParams>
{
	private static readonly IntPtr NativeFieldInfoPtr_destroyEntitiesSignal;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ProjectileStickEventParams_0;

	public unsafe DestroyEntitiesSignal destroyEntitiesSignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyEntitiesSignal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DestroyEntitiesSignal>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyEntitiesSignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destroyEntitiesSignal));
		}
	}

	static ProjectileStickEventHandler()
	{
		Il2CppClassPointerStore<ProjectileStickEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ProjectileStickEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectileStickEventHandler>.NativeClassPtr);
		NativeFieldInfoPtr_destroyEntitiesSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileStickEventHandler>.NativeClassPtr, "destroyEntitiesSignal");
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileStickEventHandler>.NativeClassPtr, 100670138);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileStickEventHandler>.NativeClassPtr, 100670139);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_ProjectileStickEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileStickEventHandler>.NativeClassPtr, 100670140);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114041, RefRangeEnd = 114042, XrefRangeStart = 114038, XrefRangeEnd = 114041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProjectileStickEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectileStickEventHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114042, XrefRangeEnd = 114047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114047, XrefRangeEnd = 114083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Execute(ProjectileStickEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventParams));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_Void_ProjectileStickEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ProjectileStickEventHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}
