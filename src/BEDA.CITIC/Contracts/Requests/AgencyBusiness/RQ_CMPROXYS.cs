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
    /// 现金管理代理收款信息上传（推送账单）请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_CMPROXYS : RqBase<RS_CMPROXYS>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "CMPROXYS"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 总笔数  必须为数字char(4)
        /// </summary>
        [XmlElement("totalNumber")]
        public int TotalNumber { get { return this.Collection?.List?.Count ?? 0; } set { } }
        /// <summary>
        /// 总金额 deciam(15,2)
        /// </summary>
        [XmlElement("totalAmount")]
        public decimal TotalAmount { get { return this.Collection?.List?.Sum(x => x.TranAmount) ?? 0; } set { } }
        /// <summary>
        /// 收款账号 char(19)
        /// </summary>
        [XmlElement("rcvAccountNo")]
        public string RcvAccountNo { get; set; }
        /// <summary>
        /// 生效日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime ValidDate { get; set; }
        /// <summary>
        /// 生效日期 char(8) 格式YYYYMMDD, 对应<see cref="ValidDate"/>
        /// </summary>
        [XmlElement("validDate")]
        public string ValidDateStr
        {
            get
            {
                return this.ValidDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ValidDate = tmp;
                }
            }
        }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<AgentReceipt> Collection { get; set; }
    }
    /// <summary>
    /// 代理收款
    /// </summary>
    public class AgentReceipt
    {
        /// <summary>
        /// 记录编号，int
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 付款账号，varchar(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 付款账户名称 varchar(122)
        /// </summary>
        [XmlElement("payAccountName")]
        public string PayAccountName { get; set; }
        /// <summary>
        /// 金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 摘要，可空 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
    }
}
