using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class DeleteBuildingSectionMessageHandler : MessageHandler<DeleteBuildingSectionMessage>
{
	private static readonly IntPtr NativeFieldInfoPtr_buildingSystemManager;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IBuildingSystemManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_DeleteBuildingSectionMessage_0;

	public unsafe IBuildingSystemManager buildingSystemManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingSystemManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IBuildingSystemManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingSystemManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildingSystemManager));
		}
	}

	static DeleteBuildingSectionMessageHandler()
	{
		Il2CppClassPointerStore<DeleteBuildingSectionMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DeleteBuildingSectionMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteBuildingSectionMessageHandler>.NativeClassPtr);
		NativeFieldInfoPtr_buildingSystemManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteBuildingSectionMessageHandler>.NativeClassPtr, "buildingSystemManager");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IBuildingSystemManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteBuildingSectionMessageHandler>.NativeClassPtr, 100663993);
		NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_DeleteBuildingSectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteBuildingSectionMessageHandler>.NativeClassPtr, 100663994);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25761, RefRangeEnd = 25762, XrefRangeStart = 25757, XrefRangeEnd = 25761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DeleteBuildingSectionMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager, IBuildingSystemManager buildingSystemManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteBuildingSectionMessageHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&networkMessageType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildingSystemManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IBuildingSystemManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25762, XrefRangeEnd = 25766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnReceiveMessage(int senderId, ref DeleteBuildingSectionMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&senderId);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref message);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_DeleteBuildingSectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DeleteBuildingSectionMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}
