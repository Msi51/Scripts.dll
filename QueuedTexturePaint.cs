using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class QueuedTexturePaint : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_otherChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_z;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureType;

	private static readonly System.IntPtr NativeFieldInfoPtr_opacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxOpacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_brushSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_falloffType;

	private static readonly System.IntPtr NativeFieldInfoPtr_affectedCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_existingTextureFilter;

	public unsafe Coordinates otherChunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherChunkCoordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherChunkCoordinates)) = coordinates;
		}
	}

	public unsafe float x
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x)) = num;
		}
	}

	public unsafe float z
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_z);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_z)) = num;
		}
	}

	public unsafe TextureType textureType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureType);
			return *(TextureType*)num;
		}
		set
		{
			*(TextureType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureType)) = textureType;
		}
	}

	public unsafe float opacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacity)) = num;
		}
	}

	public unsafe float maxOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxOpacity)) = num;
		}
	}

	public unsafe float brushSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brushSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brushSize)) = num;
		}
	}

	public unsafe FalloffType falloffType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_falloffType);
			return *(FalloffType*)num;
		}
		set
		{
			*(FalloffType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_falloffType)) = falloffType;
		}
	}

	public unsafe HashSet<Coordinates> affectedCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectedCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectedCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<TextureType> existingTextureFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_existingTextureFilter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TextureType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_existingTextureFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static QueuedTexturePaint()
	{
		Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "QueuedTexturePaint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr);
		NativeFieldInfoPtr_otherChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr, "otherChunkCoordinates");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr, "x");
		NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr, "z");
		NativeFieldInfoPtr_textureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr, "textureType");
		NativeFieldInfoPtr_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr, "opacity");
		NativeFieldInfoPtr_maxOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr, "maxOpacity");
		NativeFieldInfoPtr_brushSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr, "brushSize");
		NativeFieldInfoPtr_falloffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr, "falloffType");
		NativeFieldInfoPtr_affectedCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr, "affectedCoordinates");
		NativeFieldInfoPtr_existingTextureFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr, "existingTextureFilter");
	}

	public QueuedTexturePaint(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public QueuedTexturePaint()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueuedTexturePaint>.NativeClassPtr))
	{
	}
}
