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
    /// 删除收款单位响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLRECDEL : RsBase
    {
        /// <summary>
        /// 成功笔数int
        /// </summary>
        [XmlElement("suctotalNum")]
        public int SuctotalNum { get; set; }
        /// <summary>
        /// 失败笔数int
        /// </summary>
        [XmlElement("errToatlNums")]
        public int ErrToatlNums { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<DeletePayeeResult> List { get; set; }
    }
    /// <summary>
    /// 删除收款单位结果
    /// </summary>
    public class DeletePayeeResult
    {
        /// <summary>
        /// 账号varchar (32)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 交易状态 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

    }
}
