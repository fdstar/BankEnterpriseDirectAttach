using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 交易状态查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCIDSTT : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<TransStatus> List { get; set; }
    }
    /// <summary>
    /// 交易状态
    /// </summary>
    public class TransStatus
    {
        /// <summary>
        /// 状态标志  char(1) 0：成功；1：失败；2：未知；3：审核拒绝；4：用户撤销
        /// </summary>
        [XmlElement("stt")]
        public int Stt { get; set; }
        /// <summary>
        /// 状态代码 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 状态信息含义 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
    }
}
