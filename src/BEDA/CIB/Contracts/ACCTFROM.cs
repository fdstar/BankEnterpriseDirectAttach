using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts
{
    /// <summary>
    /// 付款人账户
    /// </summary>
    public class ACCTFROM
    {
        /// <summary>
        /// 付款账号  18位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 付款人名称(可选)  最大50位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 开户行名称(可选) 未限制，仅在报文中体现
        /// </summary>
        [XmlElement(Order = 2)]
        public string BANKDESC { get; set; }
        /// <summary>
        /// 兑付城市(可选) 未限制，仅在报文中体现
        /// </summary>
        [XmlElement(Order = 3)]
        public string CITY { get; set; }
    }
}
