using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhotoModeMenuListItem : inkListItemController
	{
		[Ordinal(0)]  [RED("CounterLabelRef")] public inkTextWidgetReference CounterLabelRef { get; set; }
		[Ordinal(1)]  [RED("HoldButtonRootWidgetRef")] public inkWidgetReference HoldButtonRootWidgetRef { get; set; }
		[Ordinal(2)]  [RED("HoldProgressRef")] public inkWidgetReference HoldProgressRef { get; set; }
		[Ordinal(3)]  [RED("LeftArrow")] public inkWidgetReference LeftArrow { get; set; }
		[Ordinal(4)]  [RED("LeftArrowInitOpacity")] public CFloat LeftArrowInitOpacity { get; set; }
		[Ordinal(5)]  [RED("LeftButton")] public inkWidgetReference LeftButton { get; set; }
		[Ordinal(6)]  [RED("OptionLabelRef")] public inkTextWidgetReference OptionLabelRef { get; set; }
		[Ordinal(7)]  [RED("OptionSelector")] public wCHandle<inkSelectorController> OptionSelector { get; set; }
		[Ordinal(8)]  [RED("OptionSelectorRef")] public inkWidgetReference OptionSelectorRef { get; set; }
		[Ordinal(9)]  [RED("OptionSelectorRootWidgetRef")] public inkWidgetReference OptionSelectorRootWidgetRef { get; set; }
		[Ordinal(10)]  [RED("OptionSelectorValues")] public CArray<gameuiPhotoModeOptionSelectorData> OptionSelectorValues { get; set; }
		[Ordinal(11)]  [RED("RightArrow")] public inkWidgetReference RightArrow { get; set; }
		[Ordinal(12)]  [RED("RightArrowInitOpacity")] public CFloat RightArrowInitOpacity { get; set; }
		[Ordinal(13)]  [RED("RightButton")] public inkWidgetReference RightButton { get; set; }
		[Ordinal(14)]  [RED("ScrollBar")] public wCHandle<inkSliderController> ScrollBar { get; set; }
		[Ordinal(15)]  [RED("ScrollBarHandleInitOpacity")] public CFloat ScrollBarHandleInitOpacity { get; set; }
		[Ordinal(16)]  [RED("ScrollBarHandleRef")] public inkWidgetReference ScrollBarHandleRef { get; set; }
		[Ordinal(17)]  [RED("ScrollBarLineInitOpacity")] public CFloat ScrollBarLineInitOpacity { get; set; }
		[Ordinal(18)]  [RED("ScrollBarLineRef")] public inkWidgetReference ScrollBarLineRef { get; set; }
		[Ordinal(19)]  [RED("ScrollBarRef")] public inkWidgetReference ScrollBarRef { get; set; }
		[Ordinal(20)]  [RED("ScrollSlidingAreaRef")] public inkWidgetReference ScrollSlidingAreaRef { get; set; }
		[Ordinal(21)]  [RED("SelectedWidgetRef")] public inkWidgetReference SelectedWidgetRef { get; set; }
		[Ordinal(22)]  [RED("SliderRootWidgetRef")] public inkWidgetReference SliderRootWidgetRef { get; set; }
		[Ordinal(23)]  [RED("SliderShowPercents")] public CBool SliderShowPercents { get; set; }
		[Ordinal(24)]  [RED("SliderValue")] public CFloat SliderValue { get; set; }
		[Ordinal(25)]  [RED("StepValue")] public CFloat StepValue { get; set; }
		[Ordinal(26)]  [RED("TextLabelRef")] public inkTextWidgetReference TextLabelRef { get; set; }
		[Ordinal(27)]  [RED("TextRootWidgetRef")] public inkWidgetReference TextRootWidgetRef { get; set; }
		[Ordinal(28)]  [RED("allowHold")] public CBool AllowHold { get; set; }
		[Ordinal(29)]  [RED("arrowClickedTime")] public CFloat ArrowClickedTime { get; set; }
		[Ordinal(30)]  [RED("fadeAnim")] public CHandle<inkanimProxy> FadeAnim { get; set; }
		[Ordinal(31)]  [RED("holdBgInitMargin")] public inkMargin HoldBgInitMargin { get; set; }
		[Ordinal(32)]  [RED("inputDirection")] public CInt32 InputDirection { get; set; }
		[Ordinal(33)]  [RED("inputHoldTime")] public CFloat InputHoldTime { get; set; }
		[Ordinal(34)]  [RED("inputStepTime")] public CFloat InputStepTime { get; set; }
		[Ordinal(35)]  [RED("isSelected")] public CBool IsSelected { get; set; }
		[Ordinal(36)]  [RED("photoModeController")] public wCHandle<gameuiPhotoModeMenuController> PhotoModeController { get; set; }

		public PhotoModeMenuListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
