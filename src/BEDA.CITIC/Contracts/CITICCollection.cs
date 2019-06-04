using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts
{
    /// <summary>
    /// 中信银行集合列表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [XmlRoot("list")]
    public class CITICCollection<T>
    {
        /// <summary>
        /// 指示当前为用户数据
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; } = "userDataList";
        /// <summary>
        /// 业务数据集合
        /// </summary>
        [XmlElement("row")]
        public List<T> List { get; set; }
    }
}
