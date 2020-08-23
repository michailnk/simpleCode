using AngleSharp.Html.Dom;
 
namespace ParserHTML.Core {
    interface IParser<T> where T:class {
        T Parse(IHtmlDocument document);
    }
}
