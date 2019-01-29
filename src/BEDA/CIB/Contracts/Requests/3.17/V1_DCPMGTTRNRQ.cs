using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.17.1活期与保证金互转请求主体
    /// </summary>
    public class V1_DCPMGTTRNRQ : IRequest<V1_DCPMGTTRNRS>
    {
        /// <summary>
        /// 3.17.1活期与保证金互转请求主体
        /// </summary>
        public DCPMGTTRNRQ DCPMGTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.17.1活期与保证金互转请求主体
    /// </summary>
    public class DCPMGTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.17.1活期与保证金互转请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public DCPMGTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.17.1活期与保证金互转请求内容
    /// </summary>
    public class DCPMGTTRN_RQBODY
    {
        /// <summary>
        /// 成员活期账户代号，18位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string MEMACCT { get; set; }
        /// <summary>
        /// 成员账号对应的担保账号，18位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string MARGINACCT { get; set; }
        /// <summary>
        /// 业务类型，1-活期转担保 2-担保转活期 必输
        /// </summary>
        [XmlElement(Order = 2)]
        public int BIZTYPE { get; set; }
        /// <summary>
        /// 金额，Decimal(17,2)	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 货币符号RMB，目前仅支持RMB	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string CURSYM { get; set; }
        /// <summary>
        /// 用途，最大50位，不允许为空或空格，不允许填换行符等非法字符	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 备注，最大60位	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string MEMO { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。 非必输
        /// 如果客户端未发送DTDUE，则服务器默认为当天，尽可能提早执行转账,如果一直未授权则3天过期。
        /// 如果预约，必须填写当日及当日之后日期，预约期限最长不超过3天。
        /// 若无预约转账要求，无需引入该节点。若有DTDUE节点，则不能为空值
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD, 对应<see cref="DTDUE"/>	非必输 
        /// 如果客户端未发送DTDUE，则服务器默认为当天，尽可能提早执行转账,如果一直未授权则3天过期。
        /// 如果预约，必须填写当日及当日之后日期，预约期限最长不超过3天。
        /// 若无预约转账要求，无需引入该节点。若有DTDUE节点，则不能为空值
        /// </summary>
        [XmlElement("DTDUE", Order = 7)]
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
    }
}
