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
    /// 3.13.7扣税流水查询响应主体
    /// </summary>
    public class V1_CHINAMOBILETAXQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.13.7扣税流水查询响应主体
        /// </summary>
        public CHINAMOBILETAXQUERYTRNRS CHINAMOBILETAXQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.13.7扣税流水查询响应主体
    /// </summary>
    public class CHINAMOBILETAXQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.13.7扣税流水查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CHINAMOBILETAXQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.13.7扣税流水查询响应内容
    /// </summary>
    public class CHINAMOBILETAXQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否还有下一页：Y－有,N－否
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.13.7扣税流水查询响应结果集合
        /// </summary>
        [XmlElement("CONTENT", Order = 3)]
        public List<CHINAMOBILETAXQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.13.7扣税流水查询响应结果明细
    /// </summary>
    public class CHINAMOBILETAXQUERYTRN_CONTENT
    {
        /// <summary>
        /// 交易时间，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTXFERPRC { get; set; }
        /// <summary>
        /// 交易时间，格式yyyy-MM-dd ,对应<see cref="DTXFERPRC"/>
        /// </summary>
        [XmlElement("DTXFERPRC", Order = 0)]
        public string DTXFERPRCStr
        {
            get
            {
                return this.DTXFERPRC.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTXFERPRC = tmp;
                }
            }
        }
        /// <summary>
        /// 缴款书交易流水号
        /// </summary>
        [XmlElement(Order = 1)]
        public string PAYBOOKSEQ { get; set; }
        /// <summary>
        /// 税票号码
        /// </summary>
        [XmlElement(Order = 2)]
        public string INVOICENUMBER { get; set; }
        /// <summary>
        /// 缴款单位名称
        /// </summary>
        [XmlElement(Order = 3)]
        public string PAYMENTUNIT { get; set; }
        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement(Order = 4)]
        public string TAXPAYERNUM { get; set; }
        /// <summary>
        /// 付款人账号
        /// </summary>
        [XmlElement(Order = 5)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 开户行行号
        /// </summary>
        [XmlElement(Order = 6)]
        public string BANKDEPOSITNO { get; set; }
        /// <summary>
        /// 征收机关代码
        /// </summary>
        [XmlElement(Order = 7)]
        public string TAXUNIFYNO { get; set; }
        /// <summary>
        /// 收款国库（银行）名称
        /// </summary>
        [XmlElement(Order = 8)]
        public string TOBANKDESC { get; set; }
        /// <summary>
        /// 合计金额
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal COUNTMONEY { get; set; }
        /// <summary>
        /// 合计条数
        /// </summary>
        [XmlElement(Order = 10)]
        public int TOTALCNT { get; set; }
        /// <summary>
        /// 税务信息
        /// </summary>
        [XmlElement(Order = 11)]
        public TAXINFO TAXINFO { get; set; }
    }
    /// <summary>
    /// 税务信息
    /// </summary>
    public class TAXINFO
    {
        /// <summary>
        /// 税（费）种名称
        /// </summary>
        [XmlElement(Order = 0)]
        public string TAXNAME { get; set; }
        /// <summary>
        /// 所属时期
        /// </summary>
        [XmlElement(Order = 1)]
        public string PERIOD { get; set; }
        /// <summary>
        /// 实缴金额
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal PAIDINMONEY { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement(Order = 3)]
        public string MEMO { get; set; }
    }
}
