using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）响应主体
    /// </summary>
    public class V1_EBPMEMBERCREDITQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）响应主体
        /// </summary>
        public EBPMEMBERCREDITQUERYTRNRS EBPMEMBERCREDITQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）响应主体
    /// </summary>
    public class EBPMEMBERCREDITQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPMEMBERCREDITQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）响应内容
    /// </summary>
    public class EBPMEMBERCREDITQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 票据总笔数	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT { get; set; }
        /// <summary>
        /// 本次查询总金额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT { get; set; }
        /// <summary>
        /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBPMEMBERCREDITQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）响应内容
    /// </summary>
    public class EBPMEMBERCREDITQUERYTRN_CONTENT
    {
        /// <summary>
        /// 成员单位客户号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string MEMBERCID { get; set; }
        /// <summary>
        /// 成员单位客户名称	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string MEMBERNAME { get; set; }
        /// <summary>
        /// 业务类型	必回
        /// 04-质押出池
        /// 05-质押转托管
        /// 08-承兑开票
        /// 11-保证金提取
        /// 12-资产业务
        /// </summary>
        [XmlElement(Order = 3)]
        public string BIZTYPE { get; set; }
        /// <summary>
        /// 申请编号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string APPLYNO { get; set; }
        /// <summary>
        /// 申请日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime APPLYDATE { get; set; }
        /// <summary>
        /// 申请日期，格式yyyy-MM-dd ,对应<see cref="APPLYDATE"/> 必回
        /// </summary>
        [XmlElement("APPLYDATE", Order = 5)]
        public string APPLYDATEStr
        {
            get
            {
                return this.APPLYDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPLYDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 保证金账号	非必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string BAILACCTNO { get; set; }
        /// <summary>
        /// 资产业务类型  非必回
        /// 01-流动资金贷款
        /// 02-国内信用证
        /// 03-法人账户透支
        /// 04-融资性保函
        /// 05-非融资性保函
        /// </summary>
        [XmlElement(Order = 7)]
        public string CAPITALBIZTYPE { get; set; }
        /// <summary>
        /// 资产业务到期日 YYYY-MM-DD 非必回
        /// </summary>
        [XmlIgnore]
        public DateTime? CAPITALDUEDATE { get; set; }
        /// <summary>
        /// 资产业务到期日，格式yyyy-MM-dd ,对应<see cref="CAPITALDUEDATE"/> 非必回
        /// </summary>
        [XmlElement("CAPITALDUEDATE", Order = 8)]
        public string CAPITALDUEDATEStr
        {
            get
            {
                return this.CAPITALDUEDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.CAPITALDUEDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CAPITALDUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 申请金额	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal APPLYAMT { get; set; }
        /// <summary>
        /// 备注  非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string MEMO { get; set; }
    }
}
