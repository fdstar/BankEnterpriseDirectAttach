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
    /// 代保管票据托收维护申请请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBDTWSQ : RqBase<RS_DLBDTWSQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBDTWSQ"; set { } }
        /// <summary>
        /// 客户流水号varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 代保管账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 代保管机构号varchar(20)
        /// </summary>
        [XmlElement("agentBranchNo")]
        public string AgentBranchNo { get; set; }
        /// <summary>
        /// 票据号varchar(16)，从票据库经办查询的结果中获取
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 票据ID int(20)，从票据库经办查询的结果中获取
        /// </summary>
        [XmlElement("billID")]
        public string BillID { get; set; }
        /// <summary>
        /// 预约标志char(1)，0：非预约；1：预约
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 预约日期
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime { get; set; }
        /// <summary>
        /// 预约日期char(8)，格式YYYYMMDD，可空，预约标志为1(预约)时非空
        /// </summary>
        [XmlElement("preDate")]
        public string PreDateStr
        {
            get
            {
                return this.AppointmentTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 是否委托银行收款标志char(1)，0：否；1：是
        /// </summary>
        [XmlElement("autoColFlg")]
        public string AutoColFlg { get; set; }
        /// <summary>
        /// 托收回款账号varchar(19)，可空，autoColFlg 为1时非空
        /// </summary>
        [XmlElement("colAccNo")]
        public string ColAccNo { get; set; }
    }
}
