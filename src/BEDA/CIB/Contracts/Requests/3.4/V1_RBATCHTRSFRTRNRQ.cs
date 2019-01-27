using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 实时批量支付与批量费用(最多100笔)请求主体
    /// </summary>
    public class V1_RBATCHTRSFRTRNRQ : IRequest<V1_RBATCHTRSFRTRNRS>
    {
        /// <summary>
        /// 实时批量支付与批量费用(最多100笔)
        /// </summary>
        public RBATCHTRSFRTRNRQ RBATCHTRSFRTRNRQ { get; set; }
    }
    /// <summary>
    /// 实时批量支付与批量费用(最多100笔)
    /// </summary>
    public class RBATCHTRSFRTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 实时批量支付与批量费用请求内容  如不传则为查询
        /// </summary>
        [XmlElement("RQBODY", Order = 1)]
        public RBATCHTRSFRTRN_RQBODY<RBATCHTRSFRTRNRQ_XFERINFO> RQBODY { get; set; }
    }
    /// <summary>
    /// 实时批量支付与批量费用请求内容
    /// </summary>
    public class RBATCHTRSFRTRN_RQBODY<T>
        where T: RBATCHTRSFRTRNRQ_XFERINFO
    {
        /// <summary>
        /// 批量指令标题，30位	非必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string TITLE { get; set; }
        /// <summary>
        /// 付款人账户信息  必输
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 批量业务类型，长度1位 必输
        /// 0表示批量支付，
        /// 1表示批量费用
        /// 2表示财付通批量支付，
        /// 3表示财付通批量费用
        /// </summary>
        [XmlElement(Order = 2)]
        public int BIZTYPE { get; set; }
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
        /// 凭证号，8位数字
        /// 可不填，默认使用电子凭证号 保留字段，非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 货币符号RMB,目前仅支持RMB	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string CURSYM { get; set; }
        /// <summary>
        /// 批量用途，最大60位，不允许为空或空格，不允许填换行符等非法字符	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。	非必输
        /// 如果预约，必须填写当日之后日期，预约期限最长不超过30天。
        /// 若无预约转账要求，无需引入该节点。若有 DTDUE 节点，则不能为空值。
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD, 对应<see cref="DTDUE"/>	非必输 
        /// 如果预约，必须填写当日之后日期，预约期限最长不超过30天。
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
        /// 批量备注，最大60位	非必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string MEMO { get; set; }
        /// <summary>
        /// 批量收款人列表，最多100笔
        /// </summary>
        [XmlElement("XFERINFO", Order = 10)]
        public List<T> List { get; set; }
    }
    /// <summary>
    /// 批量收款人信息
    /// </summary>
    public class RBATCHTRSFRTRNRQ_XFERINFO
    {
        /// <summary>
        /// 序号,最大5位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int INDX { get; set; }
        /// <summary>
        /// 收款人账户信息
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTTO ACCTTO { get; set; }
        /// <summary>
        /// 转账金额，不能为空、空格且金额必须大于0.01，必须为数值型，Decimal(17,2)，即整数位最长15位，小数位2位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 支付用途，最大60位	非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string USE { get; set; }
        /// <summary>
        /// 支付备注，最大50位	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string REMARK { get; set; }
    }
}
