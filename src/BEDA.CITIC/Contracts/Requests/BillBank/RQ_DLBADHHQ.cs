using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 大额查询查复历史信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBADHHQ : RqBase<RS_DLBADHHQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBADHHQ"; set { } }
        /// <summary>
        /// 代保管账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 票据ID int(20)，从代保管票据信息查询的结果中获取
        /// </summary>
        [XmlElement("billID")]
        public string BillID { get; set; }
        /// <summary>
        /// 票据号varchar(16)，从代保管票据信息查询的结果中获取
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
    }
}
