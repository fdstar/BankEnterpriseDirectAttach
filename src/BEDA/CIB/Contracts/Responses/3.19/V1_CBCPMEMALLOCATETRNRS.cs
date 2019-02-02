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
    /// 3.19.12跨境资金池国内成员资金调拨响应主体
    /// </summary>
    public class V1_CBCPMEMALLOCATETRNRS : IResponse
    {
        /// <summary>
        /// 3.19.12跨境资金池国内成员资金调拨响应主体
        /// </summary>
        public CBCPMEMALLOCATETRNRS CBCPMEMALLOCATETRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.12跨境资金池国内成员资金调拨响应主体
    /// </summary>
    public class CBCPMEMALLOCATETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.12跨境资金池国内成员资金调拨响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPMEMALLOCATETRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.12跨境资金池国内成员资金调拨响应内容
    /// </summary>
    public class CBCPMEMALLOCATETRN_RSBODY
    {
        /// <summary>
        /// 付款成员账号，18位主账号+6位成员子序号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string FROMACCTNO { get; set; }
        /// <summary>
        /// 付款成员名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string FROMACCTNAME { get; set; }
        /// <summary>
        /// 收款成员账号，18位主账号+6位成员子序号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string TOACCTNO { get; set; }
        /// <summary>
        /// 收款成员名称
        /// </summary>
        [XmlElement(Order = 3)]
        public string TOACCTNAME { get; set; }
        /// <summary>
        /// 金额，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 用途	非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 备注	非必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string MEMO { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。目前只支持当日 必回
        /// </summary>
        [XmlIgnore]
        public DateTime DTDUE { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。目前只支持当日, 对应<see cref="DTDUE"/>	必回
        /// </summary>
        [XmlElement("DTDUE", Order = 7)]
        public string DTDUEStr
        {
            get
            {
                return this.DTDUE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTDUE = tmp;
                }
            }
        }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
