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
    /// 26.5.支付状态查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS26_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTECKTQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKTQY";
        /// <summary>
        /// 26.5.支付状态查询响应集合
        /// </summary>
        [XmlElement("NTECKTQYZ")]
        public List<NTECKTQYZ> List { get; set; }
    }
    /// <summary>
    /// 26.5.支付状态查询响应内容
    /// </summary>
    public class NTECKTQYZ
    {
        /// <summary>
        /// 支付日期	D
        /// </summary>
        public string TRSDAT { get; set; }
        /// <summary>
        /// 支付时间	T
        /// </summary>
        public string TRSTIM { get; set; }
        /// <summary>
        /// 支付时间 由<see cref="TRSDAT"/>和<see cref="TRSTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRSDAT, this.TRSTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 支付状态	C(1)    S：成功（已汇出） B：已退票 F：失败 I：支付中
        /// </summary>
        public string TRSSTS { get; set; }
        /// <summary>
        /// 错误信息	Z(200)
        /// </summary>
        public string ERRINF { get; set; }
        /// <summary>
        /// 收方账号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收方户名	Z(122)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 收方行名称	Z(200)
        /// </summary>
        public string RCVBNK { get; set; }
        /// <summary>
        /// CPS 收方行地址	Z(62)
        /// </summary>
        public string BNKADR { get; set; }
        /// <summary>
        /// CPS 结算通道	C(1)
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 是否行内	C(1)    Y/N
        /// </summary>
        public string SYSFLG { get; set; }
        /// <summary>
        /// 支付汇路	C(3)    CPS：他行普通或者招商银行 NPS他行实时
        /// </summary>
        public string PAYCHN { get; set; }
        /// <summary>
        /// 用途或者附言	Z(200)
        /// </summary>
        public string BUSTXT { get; set; }
        /// <summary>
        /// 收款人手机	C(20)
        /// </summary>
        public string NTFNBR { get; set; }
        /// <summary>
        /// 交易请求号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 支票编号	C(10)
        /// </summary>
        public string ECKNBR { get; set; }
        /// <summary>
        /// 付款账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
    }
}
