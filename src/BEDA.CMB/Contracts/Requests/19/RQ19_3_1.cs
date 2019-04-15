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
    /// 19.3.1.电子商票单笔签发经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_1 : CMBBase<RQINFO>, IRequest<RS19_3_1>
    {
        /// <summary>
        /// SDKECPMCT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKECPMCT";
        /// <summary>
        /// 19.3.1.电子商票单笔签发经办请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 19.3.1.电子商票单笔签发经办请求内容
        /// </summary>
        public NTECPMCTX NTECPMCTX { get; set; }
    }
    /// <summary>
    /// 19.3.1.电子商票单笔签发经办请求内容
    /// </summary>
    public class NTECPMCTX
    {
        /// <summary>
        /// 出票人联行号	C(6)
        /// </summary>
        public string OPNBNK { get; set; }
        /// <summary>
        /// 出票人名称	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 出票人账号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 出票人分行号	C(2)
        /// </summary>
        public string PAYBBK { get; set; }
        /// <summary>
        /// 汇票金额	M
        /// </summary>
        public decimal TKTAMT { get; set; }
        /// <summary>
        /// 出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDTA { get; set; }
        /// <summary>
        /// 出票日期	D, 对应<see cref="OPNDTA"/>
        /// </summary>
        [XmlElement("OPNDTA")]
        public string OPNDTAStr
        {
            get
            {
                return this.OPNDTA.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDTA { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="ENDDTA"/>
        /// </summary>
        [XmlElement("ENDDTA")]
        public string ENDDTAStr
        {
            get
            {
                return this.ENDDTA.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 合同号	C(10)
        /// </summary>
        public string TSTSEQ { get; set; }
        /// <summary>
        /// 收款人名称	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收款行地址	Z(62)
        /// </summary>
        public string RCVADR { get; set; }
        /// <summary>
        /// 收款行名称	Z(62)
        /// </summary>
        public string RBKNAM { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 不可转让标志	C(1)	Y/N 缺省为N：可转让
        /// </summary>
        public string TRMFLG { get; set; }
    }
}
