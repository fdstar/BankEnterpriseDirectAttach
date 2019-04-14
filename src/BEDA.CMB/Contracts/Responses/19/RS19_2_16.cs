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
    /// 19.2.16.票据交易信息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_16 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKCUSTRS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCUSTRS";
        /// <summary>
        /// 19.2.16.票据交易信息查询响应集合
        /// </summary>
        [XmlElement("NTCUSTRSZ")]
        public List<NTCUSTRSZ> List { get; set; }
    }
    /// <summary>
    /// 19.2.16.票据交易信息查询响应内容
    /// </summary>
    public class NTCUSTRSZ
    {
        /// <summary>
        /// 经办日期	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDTA { get; set; }
        /// <summary>
        /// 经办日期	C(8), 对应<see cref="TRSDTA"/>
        /// </summary>
        [XmlElement("TRSDTA")]
        public string TRSDTAStr
        {
            get
            {
                return this.TRSDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 交易流水号	C(10)
        /// </summary>
        public string TRSSEQ { get; set; }
        /// <summary>
        /// 交易类型	C(4)	A.13 银行承兑汇票交易类型
        /// </summary>
        public string CODTPY { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal? TRSAMT { get; set; }
        /// <summary>
        /// 交易帐号	C(35)
        /// </summary>
        public string TRSACC { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 交易行机构号	C(6)
        /// </summary>
        public string TRSBNO { get; set; }
        /// <summary>
        /// 交易行名称	Z(62)
        /// </summary>
        public string BNONAM { get; set; }
        /// <summary>
        /// 交易票据中心标志	C(6)
        /// </summary>
        public string TRSBRH { get; set; }
        /// <summary>
        /// 持票人客户编号	C(10)
        /// </summary>
        public string LSTNBR { get; set; }
        /// <summary>
        /// 持票人名称	Z(62)
        /// </summary>
        public string LSTNAM { get; set; }
        /// <summary>
        /// 附件标志	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 交易备注标志	C(2)	
        /// E=额度
        /// L=贷款
        /// P=开票
        /// A=正常贴现
        /// B=买方付息贴现
        /// </summary>
        public string OPRSUB { get; set; }
        /// <summary>
        /// 交易状态	C(3)	A.14 业务状态
        /// </summary>
        public string CODSTA { get; set; }
        /// <summary>
        /// 记录状态	C(1)	A.11 记录状态
        /// </summary>
        public string RCDSTS { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 经办人	C(10)	
        /// </summary>
        public string CLKUSR { get; set; }
        /// <summary>
        /// 经办登录名	Z(30)
        /// </summary>
        public string CLKLGN { get; set; }
        /// <summary>
        /// 姓名	Z(20)
        /// </summary>
        public string CLKNAM { get; set; }
        /// <summary>
        /// 审核人	C(10)
        /// </summary>
        public string AUTUSR { get; set; }
        /// <summary>
        /// 经办登录名	Z(30)
        /// </summary>
        public string AUTLGN { get; set; }
        /// <summary>
        /// 姓名	Z(20)
        /// </summary>
        public string AUTNAM { get; set; }
    }
}
