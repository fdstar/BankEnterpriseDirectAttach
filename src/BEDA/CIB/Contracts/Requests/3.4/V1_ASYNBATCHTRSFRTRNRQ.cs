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
    /// 3.4.12异步批量支付 (最多100笔，不采用工作流) 请求主体
    /// </summary>
    public class V1_ASYNBATCHTRSFRTRNRQ : IRequest<V1_ASYNBATCHTRSFRTRNRS>
    {
        /// <summary>
        /// 3.4.12异步批量支付 (最多100笔，不采用工作流) 
        /// </summary>
        public ASYNBATCHTRSFRTRNRQ ASYNBATCHTRSFRTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.4.12异步批量支付 (最多100笔，不采用工作流) 
    /// </summary>
    public class ASYNBATCHTRSFRTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 异步批量支付请求,如果不传那么就只是查询
        /// </summary>
        [XmlElement("RQBODY", Order = 1)]
        public ASYNBATCHTRSFRTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.4.12异步批量支付请求
    /// </summary>
    public class ASYNBATCHTRSFRTRN_RQBODY: ASYNBATCHTRSFRTRN
    {
        /// <summary>
        /// 批量收款人列表，最多100笔，注意请求时不需要填<see cref="ASYNBATCHTRSFRTRN.CHEQUENUM"/>
        /// </summary>
        [XmlElement("XFERINFOTEXT", Order = 9)]
        public RQ_XFERINFOTEXT XFERINFOTEXT { get; set; }
    }
    /// <summary>
    /// 异步批量支付请求
    /// </summary>
    public abstract class ASYNBATCHTRSFRTRN
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
        /// 批量业务类型，输入0，长度1位。	非必输
        /// 0-单笔汇总批量  1-逐笔明细批量
        /// 批量业务类型为0时收款明细支持兴业及他行账户，一个批次产生一笔汇总流水及一笔交易失败的退款流水，需查批量指令对账。
        /// 批量业务类型为1时收款明细支持兴业及他行账户，一个批次产生多笔交易成功的明细流水，可查流水或批量指令对账。
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
        /// 凭证号，注意请求时不需要填该值
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
        /// 批量备注，最大60位	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string MEMO { get; set; }
    }
    /// <summary>
    /// 收款信息集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class XFERINFOTEXT<T>
        where T: PayeeInfo
    {
        /// <summary>
        /// 数量
        /// </summary>
        [XmlAttribute("size")]
        public int Size { get; set; }
        /// <summary>
        /// 文本内容
        /// 请求时 格式为  序号|收款账号|收款人名称|是否兴业银行|是否同城|收款银行行号|收款行名称|收款地址|金额|用途|备注|
        /// 响应时 格式为  序号|收款账号|收款人名称|是否兴业银行|是否同城|收款银行行号|收款行名称|收款地址|金额|用途|备注|处理状态|处理结果信息|
        /// 需保证明细中每个字段值不含‘|’，否则将引起系统解析异常
        /// </summary>
        [XmlText]
        public string Value { get; set; }
        /// <summary>
        /// 按照<see cref="Value"/>的组织格式将数据源集合转化为对应的字符串格式
        /// </summary>
        /// <param name="source"></param>
        public abstract void SetList(IEnumerable<T> source);
        /// <summary>
        /// 获取<see cref="Value"/>对应的字符串对应的数据集合
        /// </summary>
        /// <returns></returns>
        public abstract IList<T> GetList();
    }
    /// <summary>
    /// 收款人信息
    /// </summary>
    public class PayeeInfo
    {
        /// <summary>
        /// 收款账号  最长32位	必输
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 收款人名称   最长60位	必输
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否兴业银行行内转账	1位	必输，填“Y”或“N”
        /// </summary>
        public char IsCIB { get; set; }
        /// <summary>
        /// 是否同城	1位	必输，填“Y”或“N”
        /// </summary>
        public char IsSameCity { get; set; }
        /// <summary>
        /// 收款银行行号	最长14位	跨行转账建议输入
        /// </summary>
        public string BankCode { get; set; }
        /// <summary>
        /// 收款行名称	最长60位	跨行转账必输
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 收款地址	最长30位	非必输
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 金额	Decimal(17,2)	必输
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 用途	最长60位	必输
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        /// 备注	最长50位	非必输
        /// </summary>
        public string Remark { get; set; }
    }
    /// <summary>
    /// 批量收款人列表，最多100笔，SIZE为条数
    /// </summary>
    public class RQ_XFERINFOTEXT: XFERINFOTEXT<PayeeInfo>
    {
        /// <summary>
        /// 请求时不支持该方法
        /// </summary>
        /// <returns></returns>
        public override IList<PayeeInfo> GetList()
        {
            throw new NotSupportedException();
        }
        /// <summary>
        /// 设置收款人列表，转化为<see cref="XFERINFOTEXT{T}.Value"/>要求的格式
        /// </summary>
        /// <param name="payees"></param>
        public override void SetList(IEnumerable<PayeeInfo> payees)
        {
            if (payees != null && payees.Any())
            {
                var tmp = new StringBuilder();
                Action<object, bool> act = (o, b) =>
                {
                    tmp.Append(this.FixString(o, b));
                    tmp.Append('|');
                };
                var idx = 1;
                foreach (var payee in payees)
                {
                    act(idx, false);
                    act(payee.Account, true);
                    act(payee.Name, true);
                    act(payee.IsCIB, true);
                    act(payee.IsSameCity, true);
                    act(payee.BankCode, true);
                    act(payee.BankName, true);
                    act(payee.Address, true);
                    act(payee.Amount, false);
                    act(payee.Purpose, true);
                    act(payee.Remark, true);
                    tmp.AppendLine();
                    idx++;
                }
                this.Value = tmp.ToString();
                this.Size = idx - 1;
            }
        }
        private string FixString(object obj, bool fix = true)
        {
            string ret = string.Empty;
            if (obj != null)
            {
                ret = obj.ToString();
                if (fix)
                {
                    ret = ret.Replace('|', '\0');
                }
            }
            return ret;
        }
    }
}
