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
    /// 3.13.2批量工资指令提交（暂不推荐）请求主体
    /// </summary>
    public class V1_BPAYOFFTRNRQ : IRequest<V1_BPAYOFFTRNRS>
    {
        /// <summary>
        /// 3.13.2批量工资指令提交（暂不推荐）请求主体
        /// </summary>
        public BPAYOFFTRNRQ BPAYOFFTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.13.2批量工资指令提交（暂不推荐）请求主体
    /// </summary>
    public class BPAYOFFTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 在响应报文中包含该内容 	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 生成工资指令内容 若该项为空，则查询对应客户流水号的批量指令状态 非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public BPAYOFFRQ BPAYOFFRQ { get; set; }
    }
    /// <summary>
    /// 生成工资指令内容
    /// </summary>
    public class BPAYOFFRQ
    {
        /// <summary>
        /// 批量工资指令	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public BPAYOFFINFO BPAYOFFINFO { get; set; }
    }
    /// <summary>
    /// 批量工资指令
    /// </summary>
    public class BPAYOFFINFO
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
        /// 工资用途 006-工资，022-奖金，008-水费，007-电费，813-高温费，080-报刊费 长度3，仅传递标识码，如006 必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string DESCRIPTION { get; set; }
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
        /// 工资指令备注,长度50	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string REMARK { get; set; }
        /// <summary>
        /// 附件，用于描述需要上传的文件信息 批量工资指令详细信息 必输
        /// </summary>
        [XmlElement(Order = 10)]
        public ATTACHMENT ATTACHMENT { get; set; }
    }
}
