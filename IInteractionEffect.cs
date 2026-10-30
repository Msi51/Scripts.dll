using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class IInteractionEffect : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteraction_Public_Abstract_Virtual_New_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectType_Public_Abstract_Virtual_New_InteractionEffectType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllowClientRequests_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldExecuteOnClient_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_IInteraction_Entity_Entity_ActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParams_Public_Abstract_Virtual_New_IInteractionEffectParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitParams_Public_Abstract_Virtual_New_Void_IInteractionEffectParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractorEntity_Public_Abstract_Virtual_New_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetEntity_Public_Abstract_Virtual_New_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionType_Public_Abstract_Virtual_New_ActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IInteractionEffectResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEmptyResult_Public_Abstract_Virtual_New_IInteractionEffectResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnExecuted_Public_Abstract_Virtual_New_Void_IInteractionEffectResult_0;

	static IInteractionEffect()
	{
		Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IInteractionEffect");
		NativeMethodInfoPtr_GetInteraction_Public_Abstract_Virtual_New_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671243);
		NativeMethodInfoPtr_GetEffectType_Public_Abstract_Virtual_New_InteractionEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671244);
		NativeMethodInfoPtr_AllowClientRequests_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671245);
		NativeMethodInfoPtr_ShouldExecuteOnClient_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671246);
		NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_IInteraction_Entity_Entity_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671247);
		NativeMethodInfoPtr_GetParams_Public_Abstract_Virtual_New_IInteractionEffectParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671248);
		NativeMethodInfoPtr_InitParams_Public_Abstract_Virtual_New_Void_IInteractionEffectParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671249);
		NativeMethodInfoPtr_GetInteractorEntity_Public_Abstract_Virtual_New_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671250);
		NativeMethodInfoPtr_GetTargetEntity_Public_Abstract_Virtual_New_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671251);
		NativeMethodInfoPtr_GetActionType_Public_Abstract_Virtual_New_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671252);
		NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IInteractionEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671253);
		NativeMethodInfoPtr_GetEmptyResult_Public_Abstract_Virtual_New_IInteractionEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671254);
		NativeMethodInfoPtr_OnExecuted_Public_Abstract_Virtual_New_Void_IInteractionEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect>.NativeClassPtr, 100671255);
	}

	[CallerCount(0)]
	public unsafe virtual IInteraction GetInteraction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInteraction_Public_Abstract_Virtual_New_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InteractionEffectType GetEffectType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEffectType_Public_Abstract_Virtual_New_InteractionEffectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool AllowClientRequests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AllowClientRequests_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ShouldExecuteOnClient()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShouldExecuteOnClient_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Init(IInteraction interaction, Entity interactorEntity, Entity targetEntity, ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactorEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEntity);
		*(ActionType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_IInteraction_Entity_Entity_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual IInteractionEffectParams GetParams()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetParams_Public_Abstract_Virtual_New_IInteractionEffectParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteractionEffectParams>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void InitParams(IInteractionEffectParams effectParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectParams);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitParams_Public_Abstract_Virtual_New_Void_IInteractionEffectParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Entity GetInteractorEntity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInteractorEntity_Public_Abstract_Virtual_New_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity GetTargetEntity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetTargetEntity_Public_Abstract_Virtual_New_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ActionType GetActionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActionType_Public_Abstract_Virtual_New_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ActionType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual IInteractionEffectResult Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IInteractionEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteractionEffectResult>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IInteractionEffectResult GetEmptyResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEmptyResult_Public_Abstract_Virtual_New_IInteractionEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteractionEffectResult>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void OnExecuted(IInteractionEffectResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnExecuted_Public_Abstract_Virtual_New_Void_IInteractionEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IInteractionEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
public class IInteractionEffect<TParams> : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_InitParams_Public_Abstract_Virtual_New_Void_TParams_0;

	static IInteractionEffect()
	{
		Il2CppClassPointerStore<IInteractionEffect<TParams>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Scripts.dll", "", "IInteractionEffect`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TParams>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr_InitParams_Public_Abstract_Virtual_New_Void_TParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractionEffect<TParams>>.NativeClassPtr, 100671256);
	}

	[CallerCount(0)]
	public unsafe virtual void InitParams(TParams effectParams)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TParams reference;
		if (!typeof(TParams).IsValueType)
		{
			object obj = effectParams;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref effectParams;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitParams_Public_Abstract_Virtual_New_Void_TParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IInteractionEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
