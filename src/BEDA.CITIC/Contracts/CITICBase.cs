using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts
{
    /// <summary>
    /// 中信银行抽象基础类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class CITICBase<T>
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<T> Collection { get; set; }
    }
    /// <summary>
    /// 空实体
    /// </summary>
    public class EmptyBody
    {
    }
}
