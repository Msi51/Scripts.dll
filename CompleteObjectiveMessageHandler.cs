using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class CompleteObjectiveMessageHandler : MessageHandler<CompleteObjectiveMessage>
{
	private static readonly IntPtr NativeFieldInfoPtr_objectiveManager;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IObjectiveManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_CompleteObjectiveMessage_0;

	public unsafe IObjectiveManager objectiveManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IObjectiveManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveManager));
		}
	}

	static CompleteObjectiveMessageHandler()
	{
		Il2CppClassPointerStore<CompleteObjectiveMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CompleteObjectiveMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompleteObjectiveMessageHandler>.NativeClassPtr);
		NativeFieldInfoPtr_objectiveManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompleteObjectiveMessageHandler>.NativeClassPtr, "objectiveManager");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IObjectiveManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompleteObjectiveMessageHandler>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_CompleteObjectiveMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompleteObjectiveMessageHandler>.NativeClassPtr, 100663977);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25425, RefRangeEnd = 25426, XrefRangeStart = 25421, XrefRangeEnd = 25425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CompleteObjectiveMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager, IObjectiveManager objectiveManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompleteObjectiveMessageHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&networkMessageType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IObjectiveManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25426, XrefRangeEnd = 25432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnReceiveMessage(int senderId, ref CompleteObjectiveMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&senderId);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_CompleteObjectiveMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CompleteObjectiveMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}
