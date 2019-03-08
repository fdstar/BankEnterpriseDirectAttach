using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）请求主体
    /// </summary>
    public class V1_EBPMEMBERCREDITQUERYTRNRQ:IRequest<V1_EBPMEMBERCREDITQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）请求主体
        /// </summary>
        public EBPMEMBERCREDITQUERYTRNRQ EBPMEMBERCREDITQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）请求主体
    /// </summary>
    public class EBPMEMBERCREDITQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPMEMBERCREDITQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.23电子商业汇票成员用信审批查询（集团审批查询用）请求内容
    /// </summary>
    public class EBPMEMBERCREDITQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 集团票据池编号，使用“客户签约关系查询”接口获取	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string GROUPBILLPOOLNO { get; set; }
        /// <summary>
        /// 成员单位核心客户号 使用“集团关系查询”接口获取 非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string MEMBERCID { get; set; }
        /// <summary>
        /// 成员单位客户名称	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string MEMBERNAME { get; set; }
        /// <summary>
        /// 业务类型	非必输  为空时，代表查询全部
        /// 04-质押出池
        /// 05-质押转托管
        /// 08-承兑开票
        /// 11-保证金提取
        /// 12-资产业务
        /// </summary>
        [XmlElement(Order = 5)]
        public string BIZTYPE { get; set; }
        /// <summary>
        /// 保证金账号 	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string BAILACCTNO { get; set; }
        /// <summary>
        /// 资产业务类型 非必输
        /// 01-流动资金贷款
        /// 02-国内信用证
        /// 03-法人账户透支
        /// 04-融资性保函
        /// 05-非融资性保函 
        /// </summary>
        [XmlElement(Order = 7)]
        public string CAPITALBIZTYPE { get; set; }
        /// <summary>
        /// 资产业务到期日 YYYY-MM-DD	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? CAPITALDUEDATE { get; set; }
        /// <summary>
        /// 资产业务到期日 YYYY-MM-DD ,对应<see cref="CAPITALDUEDATE"/> 非必输
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
                this.CAPITALDUEDATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 申请编号	非必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string APPLYNO { get; set; }
        /// <summary>
        /// 申请日期 YYYY-MM-DD	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? APPLYDATE { get; set; }
        /// <summary>
        /// 申请日期 YYYY-MM-DD ,对应<see cref="APPLYDATE"/> 非必输
        /// </summary>
        [XmlElement("APPLYDATE", Order = 10)]
        public string APPLYDATEStr
        {
            get
            {
                return this.APPLYDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.APPLYDATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 最小申请金额(18,2)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MINAPPLYAMT { get; set; }
        /// <summary>
        /// 最小申请金额(18,2) 对应<see cref="MINAPPLYAMT"/>	非必输
        /// </summary>
        [XmlElement("MINAPPLYAMT", Order = 11)]
        public string MINAPPLYAMTStr
        {
            get
            {
                return this.MINAPPLYAMT?.ToString();
            }
            set
            {
                this.MINAPPLYAMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 最大申请金额(18,2)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MAXAPPLYAMT { get; set; }
        /// <summary>
        /// 最大申请金额(18,2) 对应<see cref="MAXAPPLYAMT"/>	非必输
        /// </summary>
        [XmlElement("MAXAPPLYAMT", Order = 12)]
        public string MAXAPPLYAMTStr
        {
            get
            {
                return this.MAXAPPLYAMT?.ToString();
            }
            set
            {
                this.MAXAPPLYAMT = value.TryConvert<decimal>();
            }
        }
    }
}
