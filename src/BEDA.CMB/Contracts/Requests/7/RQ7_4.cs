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
    /// 7.4.委托贷款放款经办请求请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ7_4 : CMBBase<RQINFO>, IRequest<RS7_4>
    {
        /// <summary>
        /// LoanOutApply
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "LoanOutApply";
        /// <summary>
        /// 7.4.委托贷款放款经办请求请求内容
        /// </summary>
        public NTOPRLNDX NTOPRLNDX { get; set; }
    }
    /// <summary>
    /// 7.4.委托贷款放款经办请求请求内容
    /// </summary>
    public class NTOPRLNDX
    {
        /// <summary>
        /// 业务类型	C(6)	N04030:委托贷款
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 委托方分行号	C(2,2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 委托方账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 委托方客户编号	C(10)   可通过7.1查询得到
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 借款方客户编号	C(10)   可调用7.2返回CLTNBR
        /// </summary>
        public string BWRCLT { get; set; }
        /// <summary>
        /// 借款方分行号	C(2,2)	附录A.1   可调用7.2 返回的BBKNBR
        /// </summary>
        public string BWRBBK { get; set; }
        /// <summary>
        /// 借款方账号	C(35)   可调用7.2 返回的ACCNBR
        /// </summary>
        public string BWRACC { get; set; }
        /// <summary>
        /// 期望放款日	D
        /// </summary>
        [XmlIgnore]
        public DateTime LONDAT { get; set; }
        /// <summary>
        /// 期望放款日	D, 对应<see cref="LONDAT"/>
        /// </summary>
        [XmlElement("LONDAT")]
        public string LONDATStr
        {
            get
            {
                return this.LONDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LONDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 币种	C(2,2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 放款金额	M
        /// </summary>
        public decimal LONAMT { get; set; }
        /// <summary>
        /// 利率	I   如果贷款合同的利率类型RATTYP为固定利率，则填写固定利率；如果为协议利率，在此可自定义利率，暂时不支持上浮利率
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 贷款用途	C(5)	A.12 贷款用途
        /// </summary>
        public string LONUSG { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 额度编号	C(10)
        /// </summary>
        public string CRLNUM { get; set; }
        /// <summary>
        /// 合同号	C(10)
        /// </summary>
        public string ACRNBR { get; set; }
    }
}
