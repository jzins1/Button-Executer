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
            ButtonParser buttonParser = new ButtonParser("%userprofile%\\Documents\\Button Executer\\buttons.xml");

            IEnumerable<string> labelList = buttonParser.ParseLabels();
            IEnumerable<string> typeList = buttonParser.ParseTypes();
            IEnumerable<string> destinationList = buttonParser.ParseTypes();
            int count = destinationList.Count();

            foreach ((string label, string type, string destination) in labelList.Zip(typeList, (l, t) => (l, t)).Zip(destinationList, (t, d) => (t.Item1, t.Item2, d)))
            {
                // Make sure button label isn't too long
                if(label.Length > 35)
                {
                    return false;
                }

                // Ensure button type is valid
                if(type != "File" || type != "Link" || type != "Command")
                {
                    return false;
                }

                // Check if link prefixes with http:// or https:// (still need to make sure it's actually at very beginning)
                if(type.Equals("Link"))
                {
                    if(!destination.Contains("http://") || !destination.Contains("https://"))
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
