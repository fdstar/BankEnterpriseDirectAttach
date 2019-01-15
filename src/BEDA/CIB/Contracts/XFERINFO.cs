using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts
{
    /// <summary>
    /// 转账信息
    /// </summary>
    public class XFERINFO
    {
        /// <summary>
        /// 付款人信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 收款人信息
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTTO ACCTTO { get; set; }
        /// <summary>
        /// 凭证号，7位数字；可不填，默认使用电子凭证号	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 货币符号,RMB ，如有该节点，请填入“RMB”	非必输，目前仅支持RMB
        /// </summary>
        [XmlElement(Order = 3)]
        public string CURSYM { get; set; }
        /// <summary>
        /// 转账金额，不能为空、空格且金额必须大于0.01，必须为数值型，decimal(17,2)，即整数位最长15位，小数位2位，以下同	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 支付方式 超级网银跨行支付必填SUPER，转账金额不可超出5万，收款行号BANKNUM必填 非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string PMTMODE { get; set; }
        /// <summary>
        /// 用款用途，最大60位，不允许为空或空格	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 客户端要求的转账执行日期，如果客户端未发送DTDUE，则服务器将尽可能早执行转账。格式：YYYY-MM-DD
        /// 如果预约，必须填写当日以后的日期，预约期限最长不超过15天。
        /// 若无预约转账需求，无需引入该节点。
        /// 若有 DTDUE 节点，则不能为空值。	非必输。
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 客户端要求的转账执行日期， yyyy-MM-dd格式 ,对应<see cref="DTDUE"/>
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
        /// <summary>
        /// 备注，可选，最大 60位	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string MEMO { get; set; }
    }
}
