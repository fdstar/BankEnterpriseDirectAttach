using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 30.3.速汇易-直连交易批次查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS30_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTESPDTY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTESPDTY";
        /// <summary>
        /// 30.3.速汇易-直连交易批次查询响应集合
        /// </summary>
        [XmlElement("NTESPDTYZ")]
        public List<NTESPDTYZ> List { get; set; }
    }
    /// <summary>
    /// 30.3.速汇易-直连交易批次查询响应内容
    /// </summary>
    public class NTESPDTYZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 速汇易协议号	C(10)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 速汇易流水号	C(20)
        /// </summary>
        public string EPSNBR { get; set; }
        /// <summary>
        /// 业务类型      	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式 	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 经办日   	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日   	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 期望日        	D
        /// </summary>
        public string EPTDAT { get; set; }
        /// <summary>
        /// 期望时间      	T
        /// </summary>
        public string EPTTIM { get; set; }
        /// <summary>
        /// 期望时间 由<see cref="EPTDAT"/>和<see cref="EPTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.EPTDAT, this.EPTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 请求状态 	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 请求结果 	C(1) 
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 付方帐号         	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 付方户名         	O(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 币种     	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易笔数     	N(6)
        /// </summary>
        public int TRSNUM { get; set; }
        /// <summary>
        /// 交易总金额       	M
        /// </summary>
        public decimal TOTAMT { get; set; }
        /// <summary>
        /// 成功笔数 	N(6)
        /// </summary>
        public int SUCNUM { get; set; }
        /// <summary>
        /// 成功金额 	M
        /// </summary>
        public decimal SUCAMT { get; set; }
        /// <summary>
        /// 用途     	Z(42)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 错误码   	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误描述 	Z(92)
        /// </summary>
        public string ERRDSP { get; set; }
    }
}