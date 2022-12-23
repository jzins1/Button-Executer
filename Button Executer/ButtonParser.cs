using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Button_Executer
{
    class ButtonParser : IButtonParser
    {
        private XmlDocument xmlFile;
        private string xmlString;
        private ButtonValidator validator;
        public ButtonParser(string xmlString)
        {
            xmlFile = new XmlDocument();
            xmlFile.Load(Environment.ExpandEnvironmentVariables(xmlString));
            this.xmlString = xmlString;
        }
        public IEnumerable<string> ParseLabels()
        {
            XmlNodeList labelList = xmlFile.GetElementsByTagName("ButtonLabel");
            List<string> labels = new List<string>();
            for(int i = 0; i < labelList.Count; i++)
            {
                labels.Add(labelList[i].InnerText.ToString());
            }
            return labels;
        }
        public IEnumerable<string> ParseTypes()
        {
            XmlNodeList typeList = xmlFile.GetElementsByTagName("ButtonType");
            List<string> types = new List<string>();
            for(int i = 0; i < typeList.Count; i++)
            {
                types.Add(typeList[i].InnerText.ToString());
            }
            return types;
        }
        public IEnumerable<string> ParseDestinations()
        {
            XmlNodeList destinationList = xmlFile.GetElementsByTagName("ButtonDestination");
            List<string> destinations = new List<string>();
            for(int i = 0; i < destinationList.Count; i++)
            {
                destinations.Add(destinationList[i].InnerText.ToString());
            }
            return destinations;
        }
    }
}
