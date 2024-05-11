using System.Xml;
using System.Xml.Linq;

public class XmlGenerator
{
    public void GenerateFromComboBox(string combo1, string combo2, string combo3)
    {
        XElement root = new XElement("Settings");

        if (!string.IsNullOrEmpty(combo1))
            root.Add(new XElement("Setting1", combo1));

        if (!string.IsNullOrEmpty(combo2))
            root.Add(new XElement("Setting2", combo2));

        if (!string.IsNullOrEmpty(combo3))
            root.Add(new XElement("Setting3", combo3));

        XmlWriter writer = XmlWriter.Create("settings.xml");
        root.Save(writer);
        writer.Close();
    }
}

// Форма

