using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLanguageFontMapping : CVariable
	{
		[Ordinal(0)]  [RED("font")] public raRef<inkFontFamilyResource> Font { get; set; }
		[Ordinal(1)]  [RED("fontSizeModifier")] public CInt16 FontSizeModifier { get; set; }
		[Ordinal(2)]  [RED("fontSizeModifierFloat")] public CFloat FontSizeModifierFloat { get; set; }
		[Ordinal(3)]  [RED("languageCode")] public CName LanguageCode { get; set; }
		[Ordinal(4)]  [RED("lineHeightModifier")] public CFloat LineHeightModifier { get; set; }
		[Ordinal(5)]  [RED("styleModifer")] public CName StyleModifer { get; set; }
		[Ordinal(6)]  [RED("trackingModifier")] public CUInt32 TrackingModifier { get; set; }

		public inkLanguageFontMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
