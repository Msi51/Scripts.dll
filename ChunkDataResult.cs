using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ChunkDataResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_success;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkData;

	public unsafe bool success
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_success);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_success)) = flag;
		}
	}

	public unsafe Chunk chunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunk);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Chunk>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunk)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk));
		}
	}

	public unsafe ChunkData chunkData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChunkData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkData));
		}
	}

	static ChunkDataResult()
	{
		Il2CppClassPointerStore<ChunkDataResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChunkDataResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkDataResult>.NativeClassPtr);
		NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataResult>.NativeClassPtr, "success");
		NativeFieldInfoPtr_chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataResult>.NativeClassPtr, "chunk");
		NativeFieldInfoPtr_chunkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataResult>.NativeClassPtr, "chunkData");
	}

	public ChunkDataResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ChunkDataResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkDataResult>.NativeClassPtr))
	{
	}
}
