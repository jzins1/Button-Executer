using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Button_Executer
{
    public class ButtonValidator
    {
        public bool validateButtons(string xmlDocument)
        {
            XmlDocument xmlFile = new XmlDocument();
            xmlFile.Load(xmlDocument);

            XmlNodeList labelList = xmlFile.GetElementsByTagName("ButtonLabel");
            XmlNodeList typeList = xmlFile.GetElementsByTagName("ButtonType");
            XmlNodeList destinationList = xmlFile.GetElementsByTagName("ButtonDestination");
            int count = destinationList.Count;

            for(int i = 0; i < count; i++)
            {
                // Make sure button label isn't too long
                if(labelList[i].InnerText.ToString().Length > 35)
                {
                    return false;
                }

                // Ensure button type is valid
                if(typeList[i].InnerText.ToString() != "File" || typeList[i].InnerText.ToString() != "Link" || typeList[i].InnerText.ToString() != "Command")
                {
                    return false;
                }

                // Check if link prefixes with http:// or https:// (still need to make sure it's actually at very beginning)
                if(typeList[i].InnerText.ToString().Equals("Link"))
                {
                    if(!destinationList[i].InnerText.ToString().Contains("http://") || !destinationList[i].InnerText.ToString().Contains("https://"))
                    {
                        return false;
                    }
                    return true;
                }
            }

            return true;
        }
    }
}
