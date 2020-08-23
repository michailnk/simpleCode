
namespace ParserHTML.Core.Habr {
    class HabrSettings : IParserSettings {
        public HabrSettings(int startPoint, int endPoint) {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public string BaseUrl { get; set; } = "https://habrahabr.ru";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get;set; }
    }
}
