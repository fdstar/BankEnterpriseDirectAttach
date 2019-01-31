using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.19.1跨境资金池资金调拨请求主体
    /// </summary>
    public class V1_CBCPALLOCATETRNRQ : IRequest<V1_CBCPALLOCATETRNRS>
    {
        /// <summary>
        /// 3.19.1跨境资金池资金调拨请求主体
        /// </summary>
        public CBCPALLOCATETRNRQ CBCPALLOCATETRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.1跨境资金池资金调拨请求主体
    /// </summary>
    public class CBCPALLOCATETRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.1跨境资金池资金调拨请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPALLOCATETRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.1跨境资金池资金调拨请求内容
    /// </summary>
    public class CBCPALLOCATETRN_RQBODY
    {
        /// <summary>
        /// 主账号，18位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string MAINACCTNO { get; set; }
        /// <summary>
        /// 成员账号，18位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string MEMACCTNO { get; set; }
        /// <summary>
        /// 调拨方向，0-归集 1-下拨 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public int ALLOCDIRECTION { get; set; }
        /// <summary>
        /// 金额，Decimal(17,2)	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 货币种类，长度2位 参考附件“货币种类编码”中的货币种类编码 必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 用途，最大50位，不允许为空或空格，不允许填换行符等非法字符	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 备注，最大60位	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string MEMO { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。目前只支持当日。	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTDUE { get; set; } = DateTime.Now;
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。目前只支持当日 对应<see cref="DTDUE"/>	必输
        /// </summary>
        [XmlElement("DTDUE", Order = 8)]
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
    }
}
