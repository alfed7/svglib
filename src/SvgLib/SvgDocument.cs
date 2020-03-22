using System.IO;
using System.Xml;

namespace SvgLib
{
    public sealed class SvgDocument : SvgContainer
    {
        private readonly XmlDocument _document;

        private SvgDocument(XmlDocument document, XmlElement element)
            : base(element)
        {
            _document = document;
        }
        public static SvgDocument Open(XmlDocument document)
        {
            var root = document.DocumentElement;
            return new SvgDocument(document, root);
        }
        public static SvgDocument Create()
        {
            var document = new XmlDocument();
            var rootElement = document.CreateElement("svg");
            document.AppendChild(rootElement);
            rootElement.SetAttribute("xmlns", "http://www.w3.org/2000/svg");
            return new SvgDocument(document, rootElement);
        }

        public void Save(Stream stream) => _document.Save(stream);

        public SvgViewBox ViewBox
        {
            get => new SvgViewBox(Element.GetAttribute("viewBox"));
            set => Element.SetAttribute("viewBox", value.ToString());
        }

        public SvgDistance Width
        {
            get => Element.GetAttribute("width", new SvgDistance());
            set => Element.SetAttribute("width", value.ToString());
        }
        public SvgDistance Height
        {
            get => Element.GetAttribute("height", new SvgDistance());
            set => Element.SetAttribute("height", value.ToString());
        }
    }
}
