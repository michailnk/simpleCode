using AngleSharp.Html.Parser;
using System;
using System.Threading.Tasks;

namespace ParserHTML.Core {
    class ParserWorker <T> where T : class{
         IParser<T> parser;
        IParserSettings parserSettings;
        HtmlLoader loader;

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;
        bool isActive;
        public bool IsActive { get => isActive; }
        public IParser<T> Parser { get => parser; set => parser = value; }
        public IParserSettings Settings { get => parserSettings; set { parserSettings = value; loader = new HtmlLoader(value); } }
        public ParserWorker(IParser<T> parser) {
            this.parser = parser;
        }

        public ParserWorker (IParser<T> parser, IParserSettings parserSettings): this(parser) {
            this.parserSettings = parserSettings;
        }

        public void Start() {
            isActive = true;
            /*Task.Run(() => */Worker(); }
        public void Abort() { }
        private async void Worker() {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++) {
                if (!isActive) {
                    OnCompleted?.Invoke(this);
                    //isActive = false;
                    return;
                }

                var source = await loader.GetSourceByPageId(i);
                var domParser = new HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);
                var result = parser.Parse(document);

                parser.Parse(document);
                OnNewData?.Invoke(this,result);
            }
            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
