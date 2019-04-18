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
    /// 8.4.10.取消通知请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_10 : CMBBase<RQINFO>, IRequest<RS8_4_10>
    {
        /// <summary>
        /// NTSMACNL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSMACNL";
        /// <summary>
        /// 8.4.10.取消通知请求内容
        /// </summary>
        public NTSMACNLX NTSMACNLX { get; set; }
    }
    /// <summary>
    /// 8.4.10.取消通知请求内容
    /// </summary>
    public class NTSMACNLX
    {
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 原转入活期账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 定期账号分行	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期账号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 通知序号	N(3,0)
        /// </summary>
        public string INFSEQ { get; set; }
        /// <summary>
        /// 通知日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INFDAT { get; set; }
        /// <summary>
        /// 通知日期	D, 对应<see cref="INFDAT"/>
        /// </summary>
        [XmlElement("INFDAT")]
        public string INFDATStr
        {
            get
            {
                return this.INFDAT.ToString("yyyyMMdd");
            }
            set
            {
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
        /// 对方参考号	C(15)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
