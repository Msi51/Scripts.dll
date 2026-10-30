using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Pool;

public class CaveDataMessageHandler : MessageHandler<CaveDataMessage>
{
	private static readonly IntPtr NativeFieldInfoPtr_bufferPool;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_ObjectPool_1_Il2CppStructArray_1_Byte_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeReceiveMessage_Protected_Virtual_Void_byref_CaveDataMessage_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_CaveDataMessage_0;

	public unsafe ObjectPool<Il2CppStructArray<byte>> bufferPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferPool);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ObjectPool<Il2CppStructArray<byte>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectPool));
		}
	}

	static CaveDataMessageHandler()
	{
		Il2CppClassPointerStore<CaveDataMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CaveDataMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaveDataMessageHandler>.NativeClassPtr);
		NativeFieldInfoPtr_bufferPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveDataMessageHandler>.NativeClassPtr, "bufferPool");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_ObjectPool_1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveDataMessageHandler>.NativeClassPtr, 100663930);
		NativeMethodInfoPtr_InitializeReceiveMessage_Protected_Virtual_Void_byref_CaveDataMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveDataMessageHandler>.NativeClassPtr, 100663931);
		NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_CaveDataMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveDataMessageHandler>.NativeClassPtr, 100663932);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25089, RefRangeEnd = 25090, XrefRangeStart = 25085, XrefRangeEnd = 25089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaveDataMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager, ObjectPool<Il2CppStructArray<byte>> bufferPool)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaveDataMessageHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&networkMessageType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bufferPool);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_ObjectPool_1_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25090, XrefRangeEnd = 25095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeReceiveMessage(ref CaveDataMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeReceiveMessage_Protected_Virtual_Void_byref_CaveDataMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25095, XrefRangeEnd = 25108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnReceiveMessage(int senderId, ref CaveDataMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&senderId);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_CaveDataMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CaveDataMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}
