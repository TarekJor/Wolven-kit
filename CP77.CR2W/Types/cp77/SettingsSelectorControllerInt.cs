using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerInt : SettingsSelectorControllerRange
	{
		[Ordinal(0)]  [RED("newValue")] public CInt32 NewValue { get; set; }
		[Ordinal(1)]  [RED("sliderController")] public wCHandle<inkSliderController> SliderController { get; set; }
		[Ordinal(2)]  [RED("sliderWidget")] public inkWidgetReference SliderWidget { get; set; }

		public SettingsSelectorControllerInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
