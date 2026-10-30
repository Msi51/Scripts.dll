using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DraggedInventoryItemUI : UIComponent
{
	private static readonly IntPtr NativeFieldInfoPtr_SLOT_ITEM_IMAGE_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_storageBarColor;

	private static readonly IntPtr NativeFieldInfoPtr_storageBarDiseasedColor;

	private static readonly IntPtr NativeFieldInfoPtr_storageBarSmeltingColor;

	private static readonly IntPtr NativeFieldInfoPtr_itemImage;

	private static readonly IntPtr NativeFieldInfoPtr_itemImageAspectRatioFilter;

	private static readonly IntPtr NativeFieldInfoPtr_quantityText;

	private static readonly IntPtr NativeFieldInfoPtr_conditionBar;

	private static readonly IntPtr NativeFieldInfoPtr_storageBar;

	private static readonly IntPtr NativeFieldInfoPtr_tilesArea;

	private static readonly IntPtr NativeFieldInfoPtr_otherStackHighlight;

	private static readonly IntPtr NativeFieldInfoPtr_positionOffsetRatio;

	private static readonly IntPtr NativeFieldInfoPtr_currentSlotSize;

	private static readonly IntPtr NativeFieldInfoPtr_targetSlot;

	private static readonly IntPtr NativeFieldInfoPtr_itemImageState;

	private static readonly IntPtr NativeFieldInfoPtr_highlightTiles;

	private static readonly IntPtr NativeMethodInfoPtr_Created_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_setState_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_setDefaultImage_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_setTiledImage_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_AsComponent_Public_UIComponent_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float SLOT_ITEM_IMAGE_SIZE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SLOT_ITEM_IMAGE_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SLOT_ITEM_IMAGE_SIZE, (void*)(&num));
		}
	}

	public unsafe static Color storageBarColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_storageBarColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_storageBarColor, (void*)(&color));
		}
	}

	public unsafe static Color storageBarDiseasedColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_storageBarDiseasedColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_storageBarDiseasedColor, (void*)(&color));
		}
	}

	public unsafe static Color storageBarSmeltingColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_storageBarSmeltingColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_storageBarSmeltingColor, (void*)(&color));
		}
	}

	public unsafe RawImage itemImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemImage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RawImage>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawImage));
		}
	}

	public unsafe AspectRatioFitter itemImageAspectRatioFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemImageAspectRatioFilter);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AspectRatioFitter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemImageAspectRatioFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aspectRatioFitter));
		}
	}

	public unsafe TextMeshProUGUI quantityText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quantityText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quantityText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe InventorySlotBarUI conditionBar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionBar);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventorySlotBarUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionBar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventorySlotBarUI));
		}
	}

	public unsafe InventorySlotBarUI storageBar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storageBar);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventorySlotBarUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storageBar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventorySlotBarUI));
		}
	}

	public unsafe Transform tilesArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tilesArea);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tilesArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Image otherStackHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherStackHighlight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherStackHighlight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Vector2 positionOffsetRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOffsetRatio);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOffsetRatio)) = vector;
		}
	}

	public unsafe float currentSlotSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSlotSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSlotSize)) = num;
		}
	}

	public unsafe InventorySlot targetSlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSlot);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventorySlot>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSlot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventorySlot));
		}
	}

	public unsafe ItemImageState itemImageState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemImageState);
			return *(ItemImageState*)num;
		}
		set
		{
			*(ItemImageState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemImageState)) = itemImageState;
		}
	}

	public unsafe Il2CppObjectBase highlightTiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightTiles);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightTiles)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	static DraggedInventoryItemUI()
	{
		Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DraggedInventoryItemUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr);
		NativeFieldInfoPtr_SLOT_ITEM_IMAGE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "SLOT_ITEM_IMAGE_SIZE");
		NativeFieldInfoPtr_storageBarColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "storageBarColor");
		NativeFieldInfoPtr_storageBarDiseasedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "storageBarDiseasedColor");
		NativeFieldInfoPtr_storageBarSmeltingColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "storageBarSmeltingColor");
		NativeFieldInfoPtr_itemImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "itemImage");
		NativeFieldInfoPtr_itemImageAspectRatioFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "itemImageAspectRatioFilter");
		NativeFieldInfoPtr_quantityText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "quantityText");
		NativeFieldInfoPtr_conditionBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "conditionBar");
		NativeFieldInfoPtr_storageBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "storageBar");
		NativeFieldInfoPtr_tilesArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "tilesArea");
		NativeFieldInfoPtr_otherStackHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "otherStackHighlight");
		NativeFieldInfoPtr_positionOffsetRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "positionOffsetRatio");
		NativeFieldInfoPtr_currentSlotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "currentSlotSize");
		NativeFieldInfoPtr_targetSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "targetSlot");
		NativeFieldInfoPtr_itemImageState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "itemImageState");
		NativeFieldInfoPtr_highlightTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, "highlightTiles");
		NativeMethodInfoPtr_Created_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, 100664872);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, 100664873);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, 100664874);
		NativeMethodInfoPtr_setState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, 100664875);
		NativeMethodInfoPtr_setDefaultImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, 100664876);
		NativeMethodInfoPtr_setTiledImage_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, 100664877);
		NativeMethodInfoPtr_AsComponent_Public_UIComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, 100664878);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr, 100664879);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38017, XrefRangeEnd = 38051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Created()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Created_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38051, XrefRangeEnd = 38056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 38355, RefRangeEnd = 38357, XrefRangeStart = 38056, XrefRangeEnd = 38355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38357, XrefRangeEnd = 38370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setDefaultImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDefaultImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38400, RefRangeEnd = 38401, XrefRangeStart = 38370, XrefRangeEnd = 38400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setTiledImage(float gridSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&gridSize);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTiledImage_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(969)]
	[CachedScanResults(RefRangeStart = 38401, RefRangeEnd = 39370, XrefRangeStart = 38401, XrefRangeEnd = 38401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIComponent AsComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsComponent_Public_UIComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIComponent>(intPtr) : null;
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DraggedInventoryItemUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraggedInventoryItemUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DraggedInventoryItemUI(IntPtr pointer)
		: base(pointer)
	{
	}
}
