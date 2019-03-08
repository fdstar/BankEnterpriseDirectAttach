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
    /// 3.6.7虚拟子账户内部转账响应主体
    /// </summary>
    public class V1_VSAINTRSFTRNRS : IResponse
    {
        /// <summary>
        /// 3.6.7虚拟子账户内部转账响应主体
        /// </summary>
        public VSAINTRSFTRNRS VSAINTRSFTRNRS { get; set; }
    }
    /// <summary>
    /// 3.6.7虚拟子账户内部转账响应主体
    /// </summary>
    public class VSAINTRSFTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.6.7虚拟子账户内部转账响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public VSAINTRSFRS VSAINTRSFRS { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 3.6.7虚拟子账户内部转账响应内容
    /// </summary>
    public class VSAINTRSFRS
    {
        /// <summary>
        /// 服务器该笔交易的唯一标识	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string SRVRID { get; set; }
        /// <summary>
        /// 实体扣款账户，最大18位	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 虚拟小序号, 最大6位	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 付款方虚拟子账号名称 最长60位 非必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string SUBNAME { get; set; }
        /// <summary>
        /// 收款方虚拟小序号最长6位 必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string TOSUBACCT { get; set; }
        /// <summary>
        /// 收款方虚拟子账号名称 最长60位 非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string TOSUBNAME { get; set; }
        /// <summary>
        /// 转账金额，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 凭证号 必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 转账用途，最大60位，非空	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 备注，最大60位，可不填	非必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string MEMO { get; set; }
        /// <summary>
        /// 转账期望日，30天以内，格式：YYYY-MM-DD，默认当天 必回
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 转账期望日，30天以内，格式：YYYY-MM-DD，默认当天, 对应<see cref="DTDUE"/> 必回
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
    }
}
