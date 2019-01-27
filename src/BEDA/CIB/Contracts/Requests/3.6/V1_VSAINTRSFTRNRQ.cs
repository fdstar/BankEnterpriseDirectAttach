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
    /// 3.6.7虚拟子账户内部转账请求主体
    /// </summary>
    public class V1_VSAINTRSFTRNRQ : IRequest<V1_VSAINTRSFTRNRS>
    {
        /// <summary>
        /// 3.6.7虚拟子账户内部转账请求主体
        /// </summary>
        public VSAINTRSFTRNRQ VSAINTRSFTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.6.7虚拟子账户内部转账请求主体
    /// </summary>
    public class VSAINTRSFTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.6.7虚拟子账户内部转账请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public VSAINTRSFRQ VSAINTRSFRQ { get; set; }
    }
    /// <summary>
    /// 3.6.7虚拟子账户内部转账请求内容
    /// </summary>
    public class VSAINTRSFRQ
    {
        /// <summary>
        /// 实体扣款账户，最大18位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 虚拟小序号, 最大6位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 付款方虚拟子账号名称 最长60位 非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string SUBNAME { get; set; }
        /// <summary>
        /// 收款方虚拟小序号最长6位 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string TOSUBACCT { get; set; }
        /// <summary>
        /// 收款方虚拟子账号名称 最长60位 非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string TOSUBNAME { get; set; }
        /// <summary>
        /// 转账金额，Decimal(17,2)	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 凭证号，可不填，默认使用电子凭证号 非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 转账用途，最大60位，非空	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 备注，最大60位，可不填	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string MEMO { get; set; }
        /// <summary>
        /// 转账期望日，30天以内，可不填 格式：YYYY-MM-DD，默认当天 非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 转账期望日，30天以内，可不填 格式：YYYY-MM-DD，默认当天, 对应<see cref="DTDUE"/>	非必输 
        /// </summary>
        [XmlElement("DTDUE", Order = 9)]
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
