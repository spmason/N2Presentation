using N2.Details;
using N2.Integrity;
using N2Presentation.Models.Parts.Questions;

namespace N2Presentation.Models.Parts
{
	[WithEditableTitle("Text", 10)]
	[RestrictParents(typeof(OptionSelectQuestion))]
	[N2.PartDefinition("Option")]
	public class Option : PartBase
	{
		[N2.Details.EditableTextBox("Answers", 100)]
		public virtual int Answers
		{
			get { return (int)(GetDetail("Answers") ?? 0); }
			set { SetDetail("Answers", value, 0); }
		}
	}
}