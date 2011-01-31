using System.Web.UI;
using System.Web.UI.WebControls;
using N2;
using N2.Details;

namespace N2Presentation.Details
{
	public class EditableTwitterUserNameAttribute : AbstractEditableAttribute
	{
		public EditableTwitterUserNameAttribute(string title, int sortOrder)
			: base(title, sortOrder)
		{
		}

		public override bool UpdateItem(ContentItem item, Control editor)
		{
			var textBox = (TextBox)editor.FindControl("userName");

			item[Name] = textBox.Text;

			return true;
		}

		public override void UpdateEditor(ContentItem item, Control editor)
		{
			var textBox = (TextBox) editor.FindControl("userName");

			textBox.Text = item[Name] as string;
		}

		protected override Control AddEditor(Control container)
		{
			var textBox = new TextBox
			              	{
			              		ID = "userName"
			              	};
			container.Controls.Add(textBox);

			container.Controls.Add(
				new LiteralControl(@"
<script>
	$('#" + textBox.ClientID +
				                   @"').keyup(function(){
		var val = $(this).val();

		console.log(val);
	});
</script>
"));

			return container;
		}
	}
}