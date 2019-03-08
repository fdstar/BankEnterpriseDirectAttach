using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）响应主体
    /// </summary>
    public class V1_MAGENTPAYTRNRS : IResponse
    {
        /// <summary>
        /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）响应主体
        /// </summary>
        public MAGENTPAYTRNRS MAGENTPAYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）响应主体
    /// </summary>
    public class MAGENTPAYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）响应内容
        /// </summary>
        [XmlElement(Order = 3)]
        public MAGENTPAYRS MAGENTPAYRS { get; set; }
    }
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）响应内容
    /// </summary>
    public class MAGENTPAYRS
    {
        /// <summary>
        /// 网银跟踪号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string SRVRTID { get; set; }
        /// <summary>
        /// 代付信息节点	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public MAGENTPAYINFORS MAGENTPAYINFO { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）代付信息节点
    /// </summary>
    public class MAGENTPAYINFORS
    {
        /// <summary>
        /// 8位商户号，指商户、个人或外围系统在收付直通车系统开立的商户号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string MRCHNO { get; set; }
        /// <summary>
        /// 订单号，最大32位 必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string ORDERNO { get; set; }
        /// <summary>
        /// 二级商户名称，最大20位
        /// </summary>
        [XmlElement(Order = 3)]
        public string MRCHNAME { get; set; }
        /// <summary>
        /// 凭证代号，9位数字 必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 付款账户信息 必回
        /// </summary>
        [XmlElement(Order = 5)]
        public ACCT ACCTFROM { get; set; }
        /// <summary>
        /// 收款人账户信息 必回
        /// </summary>
        [XmlElement(Order = 6)]
        public ACCTTO ACCTTO { get; set; }
        /// <summary>
        /// 货币符号，默认为RMB（目前仅支持人民币）
        /// </summary>
        [XmlElement(Order = 7)]
        public string CURSYM { get; set; }
        /// <summary>
        /// 交易金额，金额>0, 整数位最长15位，小数2位	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 手续费，金额>0, 整数位最长15位，小数2位
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal HANDLECHG { get; set; }
        /// <summary>
        /// 用途，最大50位	有填必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 付款日期时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlIgnore]
        public DateTime DTDUE { get; set; }
        /// <summary>
        /// 付款日期时间，格式yyyy-MM-dd HH:mm:ss, 对应<see cref="DTDUE"/>
        /// </summary>
        [XmlElement("DTDUE", Order = 11)]
        public string DTDUEStr
        {
            get
            {
                return this.DTDUE.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTDUE = tmp;
                }
            }
        }
    }
}
