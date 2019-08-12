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
    /// ECDS登记信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBADERQ : RqBase<RS_DLBADERQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBADERQ"; set { } }
        /// <summary>
        /// 代保管账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 查询类型char(1)，1：按票据ID查；2：按查询号查
        /// </summary>
        [XmlElement("qryType")]
        public int QryType { get; set; }
        /// <summary>
        /// 票据ID int(20)，可空，查询类型为1时非空，从代保管票据信息查询的结果中获取
        /// </summary>
        [XmlElement("billID")]
        public string BillID { get; set; }
        /// <summary>
        /// 查询号varchar(20)，可空，查询类型为2时非空，从委托ECDS查询查复明细查询的结果中获取
        /// </summary>
        [XmlElement("qryNo")]
        public string QryNo { get; set; }
    }
}
