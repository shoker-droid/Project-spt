using System.Xml.Serialization;

namespace SPT_Kontrol
{
    [XmlRoot(ElementName = "Tag")]
    [XmlType("Tag")]
    public class Tag : BaseTag
    {
        [XmlAttribute(AttributeName = "Ordinal")]
        public string Ordinal { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }

        [XmlAttribute(AttributeName = "Eu")]
        public string Eu { get; set; }

        [XmlAttribute(AttributeName = "Index")]
        public int Index { get; set; }
    }

    [XmlRoot(ElementName = "Tag")]
    public class TagGroupTag
    {
        [XmlAttribute(AttributeName = "Index")]
        public int Index { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }

        [XmlAttribute(AttributeName = "Eu")]
        public string Eu { get; set; }
    }


    [XmlRoot(ElementName = "TagGroup")]
    [XmlType("TagGroup")]
    public class TagGroup : BaseTag
    {

        [XmlElement(ElementName = "Tag")]
        public List<TagGroupTag> Tag { get; set; }

        [XmlAttribute(AttributeName = "Ordinal")]
        public string Ordinal { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlInclude(typeof(TagGroup))]
    [XmlInclude(typeof(Tag))]
    [XmlType(IncludeInSchema = false)]
    public abstract class BaseTag
    {

    }


    [XmlRoot(ElementName = "Channel")]
    [XmlInclude(typeof(Tag))]
    [XmlInclude(typeof(TagGroup))]
    public class Channel
    {
        [XmlElement(ElementName = "Tag", Type = typeof(Tag))]
        [XmlElement(ElementName = "TagGroup", Type = typeof(TagGroup))]
        public List<BaseTag> Tag { get; set; }

        [XmlAttribute(AttributeName = "No")]
        public int No { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Kind")]
        public string Kind { get; set; }

        [XmlAttribute(AttributeName = "Prefix")]
        public string Prefix { get; set; }

        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
    }

    [XmlRoot(ElementName = "TagList")]
    public class TagList
    {
        [XmlElement(ElementName = "Channel")]
        public List<Channel> Channel { get; set; }

        [XmlAttribute(AttributeName = "TargetDevice")]
        public string TargetDevice { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "SerialNumber")]
        public string SerialNumber { get; set; }
    }
}
