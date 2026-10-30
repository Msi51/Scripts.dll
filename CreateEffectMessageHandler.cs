using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class CreateEffectMessageHandler : MessageHandler<CreateEffectMessage>
{
	private static readonly IntPtr NativeFieldInfoPtr_worldManager;

	private static readonly IntPtr NativeFieldInfoPtr_effectsManager;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IWorldManager_IEffectsManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_CreateEffectMessage_0;

	public unsafe IWorldManager worldManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IWorldManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldManager));
		}
	}

	public unsafe IEffectsManager effectsManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectsManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEffectsManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectsManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectsManager));
		}
	}

	static CreateEffectMessageHandler()
	{
		Il2CppClassPointerStore<CreateEffectMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreateEffectMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateEffectMessageHandler>.NativeClassPtr);
		NativeFieldInfoPtr_worldManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateEffectMessageHandler>.NativeClassPtr, "worldManager");
		NativeFieldInfoPtr_effectsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateEffectMessageHandler>.NativeClassPtr, "effectsManager");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IWorldManager_IEffectsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateEffectMessageHandler>.NativeClassPtr, 100663989);
		NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_CreateEffectMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateEffectMessageHandler>.NativeClassPtr, 100663990);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25728, RefRangeEnd = 25729, XrefRangeStart = 25723, XrefRangeEnd = 25728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreateEffectMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager, IWorldManager worldManager, IEffectsManager effectsManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateEffectMessageHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&networkMessageType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectsManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IWorldManager_IEffectsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25729, XrefRangeEnd = 25738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnReceiveMessage(int senderId, ref CreateEffectMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&senderId);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_CreateEffectMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreateEffectMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}
