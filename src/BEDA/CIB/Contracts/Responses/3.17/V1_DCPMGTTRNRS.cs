using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.17.1活期与保证金互转响应主体
    /// </summary>
    public class V1_DCPMGTTRNRS : IResponse
    {
        /// <summary>
        /// 3.17.1活期与保证金互转响应主体
        /// </summary>
        public DCPMGTTRNRS DCPMGTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.17.1活期与保证金互转响应主体
    /// </summary>
    public class DCPMGTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.17.1活期与保证金互转响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public DCPMGTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.17.1活期与保证金互转响应内容
    /// </summary>
    public class DCPMGTTRN_RSBODY
    {
        /// <summary>
        /// 成员活期账户代号，18位
        /// </summary>
        [XmlElement(Order = 0)]
        public string MEMACCT { get; set; }
        /// <summary>
        /// 成员活期账户名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string MEMACCTNAME { get; set; }
        /// <summary>
        /// 成员账号对应的担保账号，18位
        /// </summary>
        [XmlElement(Order = 2)]
        public string MARGINACCT { get; set; }
        /// <summary>
        /// 成员账号对应的担保账号名称
        /// </summary>
        [XmlElement(Order = 3)]
        public string MARGINACCTNAME { get; set; }
        /// <summary>
        /// 业务类型，1-活期转担保 2-担保转活期
        /// </summary>
        [XmlElement(Order = 4)]
        public int BIZTYPE { get; set; }
        /// <summary>
        /// 金额，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 凭证号
        /// </summary>
        [XmlElement(Order = 6)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 货币符号RMB，目前仅支持RMB
        /// </summary>
        [XmlElement(Order = 7)]
        public string CURSYM { get; set; }
        /// <summary>
        /// 用途，最大50位，不允许为空或空格，不允许填换行符等非法字符
        /// </summary>
        [XmlElement(Order = 8)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 备注，最大60位
        /// </summary>
        [XmlElement(Order = 9)]
        public string MEMO { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD, 对应<see cref="DTDUE"/>
        /// </summary>
        [XmlElement("DTDUE", Order = 10)]
        public string DTDUEStr
        {
            get
            {
                return this.DTDUE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTDUE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 批量指令处理状态
        /// </summary>
        [XmlElement(Order = 11)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
