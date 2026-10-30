using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;

public sealed class InteractionEffectExecuteMessage : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectType;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactorEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_effect;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectParams;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_InteractionType_InteractionEffectType_Int32_Int32_ActionType_IInteractionEffectParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe uint interactionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionId);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionId)) = num;
		}
	}

	public unsafe InteractionType interactionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionType);
			return *(InteractionType*)num;
		}
		set
		{
			*(InteractionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionType)) = interactionType;
		}
	}

	public unsafe InteractionEffectType effectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectType);
			return *(InteractionEffectType*)num;
		}
		set
		{
			*(InteractionEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectType)) = interactionEffectType;
		}
	}

	public unsafe int interactorEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactorEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactorEntityId)) = num;
		}
	}

	public unsafe int targetEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetEntityId)) = num;
		}
	}

	public unsafe ActionType actionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionType);
			return *(ActionType*)num;
		}
		set
		{
			*(ActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionType)) = actionType;
		}
	}

	public unsafe IInteractionEffect effect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteractionEffect>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionEffect));
		}
	}

	public unsafe IInteractionEffectParams effectParams
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectParams);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteractionEffectParams>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectParams)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionEffectParams));
		}
	}

	static InteractionEffectExecuteMessage()
	{
		Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InteractionEffectExecuteMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr);
		NativeFieldInfoPtr_interactionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr, "interactionId");
		NativeFieldInfoPtr_interactionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr, "interactionType");
		NativeFieldInfoPtr_effectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr, "effectType");
		NativeFieldInfoPtr_interactorEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr, "interactorEntityId");
		NativeFieldInfoPtr_targetEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr, "targetEntityId");
		NativeFieldInfoPtr_actionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr, "actionType");
		NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr, "effect");
		NativeFieldInfoPtr_effectParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr, "effectParams");
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_InteractionType_InteractionEffectType_Int32_Int32_ActionType_IInteractionEffectParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr, 100664077);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr, 100664078);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 26600, RefRangeEnd = 26602, XrefRangeStart = 26598, XrefRangeEnd = 26600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractionEffectExecuteMessage(uint interactionId, InteractionType interactionType, InteractionEffectType effectType, int interactorEntityId, int targetEntityId, ActionType actionType, IInteractionEffectParams effectParams)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&interactionId);
		*(InteractionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &interactionType;
		*(InteractionEffectType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &effectType;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &interactorEntityId;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetEntityId;
		*(ActionType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectParams);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_InteractionType_InteractionEffectType_Int32_Int32_ActionType_IInteractionEffectParams_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26602, XrefRangeEnd = 26619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InteractionEffectExecuteMessage(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InteractionEffectExecuteMessage()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionEffectExecuteMessage>.NativeClassPtr))
	{
	}
}
