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
    /// 19.2.1.经办票据信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_1 : CMBBase<RQINFO>, IRequest<RS19_2_1>
    {
        /// <summary>
        /// SDKOPRINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKOPRINQ";
        /// <summary>
        /// 19.2.1.经办票据信息查询请求内容
        /// </summary>
        public NTOPRINQX NTOPRINQX { get; set; }
    }
    /// <summary>
    /// 19.2.1.经办票据信息查询请求内容
    /// </summary>
    public class NTOPRINQX
    {
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string LSTNBR { get; set; }
        /// <summary>
        /// 起始流水号	C(10)
        /// </summary>
        public string BEGSEQ { get; set; }
        /// <summary>
        /// 结束流水号	C(10)
        /// </summary>
        public string ENDSEQ { get; set; }
        /// <summary>
        /// 起始到期日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? BEGDT1 { get; set; }
        /// <summary>
        /// 起始到期日期	D, 对应<see cref="BEGDT1"/>
        /// </summary>
        [XmlElement("BEGDT1")]
        public string BEGDT1Str
        {
            get
            {
                return this.BEGDT1?.ToString("yyyyMMdd");
            }
            set
            {
                this.BEGDT1 = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDT1 = tmp;
                }
            }
        }
        /// <summary>
        /// 结束到期日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDT2 { get; set; }
        /// <summary>
        /// 结束到期日期	D, 对应<see cref="ENDDT2"/>
        /// </summary>
        [XmlElement("ENDDT2")]
        public string ENDDT2Str
        {
            get
            {
                return this.ENDDT2?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDT2 = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDT2 = tmp;
                }
            }
        }
        /// <summary>
        /// 起始出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? BEGDAT { get; set; }
        /// <summary>
        /// 起始出票日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.BEGDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDAT { get; set; }
        /// <summary>
        /// 结束出票日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 起始出票金额	M
        /// </summary>
        public decimal? BEGAMT { get; set; }
        /// <summary>
        /// 结束出票金额	M
        /// </summary>
        public decimal? ENDAMT { get; set; }
        /// <summary>
        /// 票据号标志	C(4)
        /// </summary>
        public string TKTSQF { get; set; }
        /// <summary>
        /// 票据号	C(20)
        /// </summary>
        public string TKTSEQ { get; set; }
        /// <summary>
        /// 经办类型	C(4)	银行承兑汇票：A.9 经办类型；商业承兑汇票：A.15 经办类型（商业承兑汇票）
        /// </summary>
        public string CODTPY { get; set; }
        /// <summary>
        /// 续传流水号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
    }
}
