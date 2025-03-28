using iText.Kernel.Pdf;

namespace TheatricalPlayersRefactoringKata.Domain.Utils.extrato;

public interface IHtmlToPdfConverter
{
    IHtmlToPdfConverter PdfTemplatePath(string templatePath);
    IHtmlToPdfConverter CssTemplatePath(string cssTemplatePath);
    IHtmlToPdfConverter HtmlTemplate(string templatePath, Dictionary<string, object> data);
    byte[] Create();
}