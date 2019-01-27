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
    /// 3.13.1批量汇款指令提交（暂不推荐）请求主体
    /// </summary>
    public class V1_BATCHTRNRQ : IRequest<V1_BATCHTRNRS>
    {
        /// <summary>
        /// 3.13.1批量汇款指令提交（暂不推荐）请求主体
        /// </summary>
        public BATCHTRNRQ BATCHTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.13.1批量汇款指令提交（暂不推荐）请求主体
    /// </summary>
    public class BATCHTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 在响应报文中包含该内容 	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 生成转账付出指令内容 若该项为空，则查询对应客户流水号的批量指令状态 非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public BATCHRQ BATCHRQ { get; set; }
    }
    /// <summary>
    /// 生成转账付出指令内容
    /// </summary>
    public class BATCHRQ
    {
        /// <summary>
        /// 转账信息	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public BATCHINFO BATCHINFO { get; set; }
    }
    /// <summary>
    /// 转账信息
    /// </summary>
    public class BATCHINFO
    {
        /// <summary>
        /// 付款人账户
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 批量支付指令标题,长度：50	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string TITLE { get; set; }
        /// <summary>
        /// 总笔数，整数	非必输
        /// </summary>
        [XmlIgnore]
        public int? TOTALCOUNT { get; set; }
        /// <summary>
        /// 总笔数，整数  对应<see cref="TOTALCOUNT"/>	非必输
        /// </summary>
        [XmlElement("TOTALCOUNT", Order = 3)]
        public string TOTALCOUNTStr
        {
            get
            {
                return this.TOTALCOUNT?.ToString();
            }
            set
            {
                this.TOTALCOUNT = value.TryConvert<int>();
            }
        }
        /// <summary>
        /// 总金额，Decimal(17,2)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? TOTALAMOUNT { get; set; }
        /// <summary>
        /// 总金额，整数  对应<see cref="TOTALAMOUNT"/>	非必输
        /// </summary>
        [XmlElement("TOTALAMOUNT", Order = 4)]
        public string TOTALAMOUNTStr
        {
            get
            {
                return this.TOTALAMOUNT?.ToString();
            }
            set
            {
                this.TOTALAMOUNT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 批量业务类型，目前仅仅支持(批量支付 0; 批量费用1),长度1 必输
        /// </summary>
        [XmlElement(Order = 5)]
        public int BIZTYPE { get; set; }
        /// <summary>
        /// 凭证号,目前批量支付指令所有交易均为自动生成凭证,长度 8	保留字段（不使用）
        /// </summary>
        [XmlElement(Order = 6)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 货币符号,RMB,目前仅支持RMB	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string CURSYM { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。	非必输
        /// 如果预约，必须填写当日之后日期，允许填写当日至当日加15天。
        /// 若无预约转账要求，无需引入该节点。若有 DTDUE 节点，则不能为空值。
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD, 对应<see cref="DTDUE"/>	非必输 
        /// 如果预约，必须填写当日之后日期，允许填写当日至当日加15天。
        /// 若无预约转账要求，无需引入该节点。若有 DTDUE 节点，则不能为空值。
        /// </summary>
        [XmlElement("DTDUE", Order = 8)]
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
        /// 附件，用于描述需要上传的文件信息 批量转账指令详细信息 必输
        /// </summary>
        [XmlElement(Order = 9)]
        public ATTACHMENT ATTACHMENT { get; set; }
    }
    /// <summary>
    /// 附件声明
    /// </summary>
    public class ATTACHMENT
    {
        /// <summary>
        /// 文件名称，可以根据路径匹配 如：/test/test/test.text 或 test.text 最大长度：100
        /// 请不要使用汉字或者其他特殊字符集，避免出现码制问题。	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string FILENAME { get; set; }
        /// <summary>
        /// 附件类型,目前仅有TEXT,最大长度15	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string TYPE { get; set; }
        /// <summary>
        /// 文本字符集,默认为GBK,最大长度20	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string CHARSET { get; set; }
        /// <summary>
        /// 文件摘要
        /// </summary>
        [XmlElement(Order = 3)]
        public DIGEST DIGEST { get; set; }
    }
    /// <summary>
    /// 文件摘要
    /// </summary>
    public class DIGEST
    {
        /// <summary>
        /// 摘要方法,默认为MD5,最大长度：10	非必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string METHOD { get; set; }
        /// <summary>
        /// 摘要,长度32	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string VALUE { get; set; }
    }
}
