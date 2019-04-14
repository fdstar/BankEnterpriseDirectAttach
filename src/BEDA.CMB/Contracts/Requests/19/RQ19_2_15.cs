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
    /// 19.2.15.票据信息综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_15 : CMBBase<RQINFO>, IRequest<RS19_2_15>
    {
        /// <summary>
        /// SDKMAGINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMAGINQ";
        /// <summary>
        /// 19.2.15.票据信息综合查询请求内容
        /// </summary>
        public NTMAGINQX NTMAGINQX { get; set; }
    }
    /// <summary>
    /// 19.2.15.票据信息综合查询请求内容
    /// </summary>
    public class NTMAGINQX
    {
        /// <summary>
        /// 网上票据标志	C(1)	E=表示电子票据 A=实物票据 T=表示实物托管票据  空查询全部
        /// </summary>
        public string NETFLG { get; set; }
        /// <summary>
        /// 票据当前交易状态	C(1)	A.12 票据交易状态 空查询全部
        /// </summary>
        public string TRSSTA { get; set; }
        /// <summary>
        /// 汇票状态	C(1)	A.10 汇票状态   空查询全部
        /// </summary>
        public string TKTSTA { get; set; }
        /// <summary>
        /// 起始日托管日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDTA { get; set; }
        /// <summary>
        /// 起始日托管日期	D, 对应<see cref="TRSDTA"/>
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
        /// 结束托管日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? FINDTA { get; set; }
        /// <summary>
        /// 结束托管日期	D, 对应<see cref="FINDTA"/>
        /// </summary>
        [XmlElement("FINDTA")]
        public string FINDTAStr
        {
            get
            {
                return this.FINDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.FINDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.FINDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 起始票据流水号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 结束票据流水号	C(10)
        /// </summary>
        public string FINSEQ { get; set; }
        /// <summary>
        /// 票据号标志	C(4)
        /// </summary>
        public string TKTSQF { get; set; }
        /// <summary>
        /// 票据号	C(20)
        /// </summary>
        public string TKTSEQ { get; set; }
        /// <summary>
        /// 付款行全称	Z(62)
        /// </summary>
        public string BNKNAM { get; set; }
        /// <summary>
        /// 出票人名称	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 起始汇票金额	M
        /// </summary>
        public decimal? TKTAMT { get; set; }
        /// <summary>
        /// 结束汇票金额	M
        /// </summary>
        public decimal? FINAMT { get; set; }
        /// <summary>
        /// 起始出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPNDTA { get; set; }
        /// <summary>
        /// 起始出票日期	D, 对应<see cref="OPNDTA"/>
        /// </summary>
        [XmlElement("OPNDTA")]
        public string OPNDTAStr
        {
            get
            {
                return this.OPNDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPNDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 结束出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPNFIN { get; set; }
        /// <summary>
        /// 结束出票日期	D, 对应<see cref="OPNFIN"/>
        /// </summary>
        [XmlElement("OPNFIN")]
        public string OPNFINStr
        {
            get
            {
                return this.OPNFIN?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPNFIN = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNFIN = tmp;
                }
            }
        }
        /// <summary>
        /// 起始到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDTA { get; set; }
        /// <summary>
        /// 起始到期日	D, 对应<see cref="ENDDTA"/>
        /// </summary>
        [XmlElement("ENDDTA")]
        public string ENDDTAStr
        {
            get
            {
                return this.ENDDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 结束到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDFIN { get; set; }
        /// <summary>
        /// 结束到期日	D, 对应<see cref="ENDFIN"/>
        /// </summary>
        [XmlElement("ENDFIN")]
        public string ENDFINStr
        {
            get
            {
                return this.ENDFIN?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDFIN = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDFIN = tmp;
                }
            }
        }
        /// <summary>
        /// 到期天数	C(3)
        /// </summary>
        public string DURDTA { get; set; }
        /// <summary>
        /// 持票人名称	Z(62)
        /// </summary>
        public string LSTNAM { get; set; }
        /// <summary>
        /// 托管票据中心	C(6)
        /// </summary>
        public string SAVBRH { get; set; }
        /// <summary>
        /// 托管票据来源	C(10)
        /// </summary>
        public string SAVSOC { get; set; }
    }
}
