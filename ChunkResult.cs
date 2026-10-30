using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ChunkResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_success;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunk;

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

	static ChunkResult()
	{
		Il2CppClassPointerStore<ChunkResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChunkResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkResult>.NativeClassPtr);
		NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkResult>.NativeClassPtr, "success");
		NativeFieldInfoPtr_chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkResult>.NativeClassPtr, "chunk");
	}

	public ChunkResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ChunkResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkResult>.NativeClassPtr))
	{
	}
}
