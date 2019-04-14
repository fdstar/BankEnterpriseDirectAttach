using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 19.2.16.票据交易信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_16 : CMBBase<RQINFO>, IRequest<RS19_2_16>
    {
        /// <summary>
        /// SDKCUSTRS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCUSTRS";
        /// <summary>
        /// 19.2.16.票据交易信息查询请求内容
        /// </summary>
        public NTCUSTRSX NTCUSTRSX { get; set; }
    }
    /// <summary>
    /// 19.2.16.票据交易信息查询请求内容
    /// </summary>
    public class NTCUSTRSX
    {
        /// <summary>
        /// 起始经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDTA { get; set; }
        /// <summary>
        /// 起始经办日期	D, 对应<see cref="TRSDTA"/>
        /// </summary>
        [XmlElement("TRSDTA")]
        public string TRSDTAStr
        {
            get
            {
                return this.TRSDTA.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 结束经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime FINDTA { get; set; }
        /// <summary>
        /// 结束经办日期	D, 对应<see cref="FINDTA"/>
        /// </summary>
        [XmlElement("FINDTA")]
        public string FINDTAStr
        {
            get
            {
                return this.FINDTA.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.FINDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 交易类型	C(4)	银行承兑：A.13 银行承兑汇票交易类型；   空查询全部
        /// </summary>
        public string CODTPY { get; set; }
        /// <summary>
        /// 业务状态	C(3)	A.14 业务状态   空查询全部
        /// </summary>
        public string CODSTA { get; set; }
        /// <summary>
        /// 交易机构名称	Z(62)
        /// </summary>
        public string BNONAM { get; set; }
        /// <summary>
        /// 交易帐号	C(35)
        /// </summary>
        public string TRSACC { get; set; }
        /// <summary>
        /// 起始交易金额	M
        /// </summary>
        public decimal? TRSAMT { get; set; }
        /// <summary>
        /// 结束交易金额	M
        /// </summary>
        public decimal? FINAMT { get; set; }
        /// <summary>
        /// 票据凭证号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 票据号标志	C(4)
        /// </summary>
        public string TKTSQF { get; set; }
        /// <summary>
        /// 票据号	C(20)
        /// </summary>
        public string TKTSEQ { get; set; }
        /// <summary>
        /// 持票人名称	Z(62)
        /// </summary>
        public string LSTNAM { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
