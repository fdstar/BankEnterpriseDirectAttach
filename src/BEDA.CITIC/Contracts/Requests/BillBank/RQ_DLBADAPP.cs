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
    /// 票据库交易申请请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBADAPP : RqBase<RS_DLBADAPP>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBADAPP"; set { } }
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
        /// 申请类型varchar(2)，值域见附录4.3，取值1、2、3、4、5、6、8、9
        /// </summary>
        [XmlElement("appType")]
        public int AppType { get; set; }
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
        /// 经办备注varchar(256)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 取票人姓名varchar(60)，可空，当申请类型为1(取票申请)时有效
        /// 取票人姓名、取票人证件号、取票人证件类型必须同时为空或同时非空
        /// </summary>
        [XmlElement("takerName")]
        public string TakerName { get; set; }
        /// <summary>
        /// 取票人证件号varchar(30)，可空，当申请类型为1(取票申请)时有效
        /// 取票人姓名、取票人证件号、取票人证件类型必须同时为空或同时非空
        /// </summary>
        [XmlElement("takerID")]
        public string TakerID { get; set; }
        /// <summary>
        /// 取票人证件类型char(1)，可空，当申请类型为1(取票申请)时有效，值域见附录4.6
        /// 取票人姓名、取票人证件号、取票人证件类型必须同时为空或同时非空
        /// </summary>
        [XmlElement("takerIDType")]
        public string TakerIDType { get; set; }
        /// <summary>
        /// 转让标识char(4)，EM00：可再转让；EM01：不可再转让，可空，申请类型为2(贴现申请)时非空
        /// </summary>
        [XmlElement("endorseMk")]
        public string EndorseMk { get; set; }
        /// <summary>
        /// 业务办理机构联行号varchar(20)，可空，当申请类型为2(贴现申请)或5(质押申请)时非空，从代保管机构查询返回结果中获取
        /// </summary>
        [XmlElement("bsnBranchNo")]
        public string BsnBranchNo { get; set; }
    }
}
