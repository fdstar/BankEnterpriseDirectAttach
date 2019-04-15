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
    /// 19.3.8.电子商票交易信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_8 : CMBBase<RQINFO>, IRequest<RS19_3_8>
    {
        /// <summary>
        /// SDKMCHTRS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMCHTRS";
        /// <summary>
        /// 19.3.8.电子商票交易信息查询请求内容
        /// </summary>
        public NTMCHTRSX NTMCHTRSX { get; set; }
    }
    /// <summary>
    /// 19.3.8.电子商票交易信息查询请求内容
    /// </summary>
    public class NTMCHTRSX
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
        /// 交易类型	C(4)	商业承兑：A.15 经办类型（商业承兑汇票）  空查询全部
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
