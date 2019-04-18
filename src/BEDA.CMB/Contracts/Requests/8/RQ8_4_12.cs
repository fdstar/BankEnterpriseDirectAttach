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
    /// 8.4.12.提前支取通知存款请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_12 : CMBBase<RQINFO>, IRequest<RS8_4_12>
    {
        /// <summary>
        /// NTSMAWOP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSMAWOP";
        /// <summary>
        /// 8.4.12.提前支取通知存款请求内容
        /// </summary>
        public NTSMAWOPX NTSMAWOPX { get; set; }
    }
    /// <summary>
    /// 8.4.12.提前支取通知存款请求内容
    /// </summary>
    public class NTSMAWOPX
    {
        /// <summary>
        /// 业务类型	C(6)	N08010: 定活互转
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 活期账号分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 定期帐号分行号	C(2)	附录A.1
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 通知标记	C(1)	N：支取未发通知存款；Y：支取已发通知存款
        /// </summary>
        public string INFFLG { get; set; }
        /// <summary>
        /// 通知序号	N(3,0)  如果INFFLG=Y则不能为空
        /// </summary>
        public string INFSEQ { get; set; }
        /// <summary>
        /// 通知日期	D   如果INFFLG=Y则不能为空
        /// </summary>
        [XmlIgnore]
        public DateTime? INFDAT { get; set; }
        /// <summary>
        /// 通知日期	D, 对应<see cref="INFDAT"/>
        /// </summary>
        [XmlElement("INFDAT")]
        public string INFDATStr
        {
            get
            {
                return this.INFDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.INFDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INFDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 对方参考号	C(15)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
