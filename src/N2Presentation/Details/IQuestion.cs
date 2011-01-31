using System.Web.Mvc;

namespace N2Presentation.Details
{
	public interface IQuestion
	{
		MvcHtmlString CreateHtmlElement();

		string QuestionText { get; }
		string ElementID { get; }

		void AppendAnswer(AnswerContext context, string postedValue);
	}
}