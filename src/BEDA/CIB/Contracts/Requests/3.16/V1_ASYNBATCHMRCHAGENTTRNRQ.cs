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
    /// 3.16.2收付直通车批量代付(最多100笔，不采用工作流)请求主体
    /// </summary>
    public class V1_ASYNBATCHMRCHAGENTTRNRQ : IRequest<V1_ASYNBATCHMRCHAGENTTRNRS>
    {
        /// <summary>
        /// 3.16.2收付直通车批量代付(最多100笔，不采用工作流)请求主体
        /// </summary>
        public ASYNBATCHMRCHAGENTTRNRQ ASYNBATCHMRCHAGENTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.16.2收付直通车批量代付(最多100笔，不采用工作流)请求主体
    /// </summary>
    public class ASYNBATCHMRCHAGENTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.16.2收付直通车批量代付(最多100笔，不采用工作流)请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ASYNBATCHMRCHAGENTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.16.2收付直通车批量代付(最多100笔，不采用工作流)请求内容
    /// </summary>
    public class ASYNBATCHMRCHAGENTTRN_RQBODY
    {
        /// <summary>
        /// 批量指令标题，30位	非必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string TITLE { get; set; }
        /// <summary>
        /// 总笔数，整数	非必输
        /// </summary>
        [XmlIgnore]
        public int? TOTALCOUNT { get; set; }
        /// <summary>
        /// 总笔数，整数  对应<see cref="TOTALCOUNT"/>	非必输
        /// </summary>
        [XmlElement("TOTALCOUNT", Order = 1)]
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
        [XmlElement("TOTALAMOUNT", Order = 2)]
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
        /// 商户代号 最大8位(商户、个人或外围系统在收付直通车系统开立的商户代号)	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string MRCHNO { get; set; }
        /// <summary>
        /// 付款人账户信息 必输
        /// </summary>
        [XmlElement(Order = 4)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 批量用途，最大60位，不允许填换行符等非法字符	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 批量备注，最大60位	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string MEMO { get; set; }
        /// <summary>
        /// 期望转账日期yyyy-MM-dd 期望转账日期必须是今天 非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? EXPECT_DATE { get; set; }
        /// <summary>
        /// 期望转账日期yyyy-MM-dd 期望转账日期必须是今天, 对应<see cref="EXPECT_DATE"/>	非必输 
        /// </summary>
        [XmlElement("EXPECT_DATE", Order = 7)]
        public string EXPECT_DATEStr
        {
            get
            {
                return this.EXPECT_DATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.EXPECT_DATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 批量收款人列表，最多100笔
        /// </summary>
        [XmlElement(Order = 8)]
        public ASYNBATCHMRCHAGENTTRNRQ_XFERINFOTEXT XFERINFOTEXT { get; set; }
    }
    /// <summary>
    /// 批量收款人列表，最多100笔
    /// </summary>
    public class ASYNBATCHMRCHAGENTTRNRQ_XFERINFOTEXT : XFERINFOTEXT<PayeeInfo_3_16_2>
    {
        /// <summary>
        /// 请求时不支持该方法
        /// </summary>
        /// <returns></returns>
        public override IList<PayeeInfo_3_16_2> GetList()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 设置收款人列表，转化为接口要求的格式
        /// 请求时 格式为  序号|订单号|二级商户名称|收款账号|收款人名称|收款银行人行支付行号|对方账户类型|收款银行人行支付行名|金额|用途|
        /// 响应时 格式为  序号|订单号|二级商户名称|收款账号|收款人名称|收款银行人行支付行号|对方账户类型|收款银行人行支付行名|金额|用途|手续费|处理状态|处理结果信息|
        /// 需保证明细中每个字段值不含‘|’，否则将引起系统解析异常
        /// </summary>
        /// <param name="payees"></param>
        public override void SetList(IEnumerable<PayeeInfo_3_16_2> payees)
        {
            if (payees != null && payees.Any())
            {
                var tmp = new StringBuilder();
                Action<object, bool> act = (o, b) =>
                {
                    tmp.Append(this.ReplaceChar(o, b));
                    tmp.Append('|');
                };
                var idx = 1;
                foreach (var payee in payees)
                {
                    act(idx, false);
                    act(payee.OrderNo, true);
                    act(payee.MerchantName, true);
                    act(payee.Account, true);
                    act(payee.Name, true);
                    act(payee.BankCode, true);
                    act(payee.AccountType, false);
                    act(payee.BankName, true);
                    act(payee.Amount, false);
                    act(payee.Purpose, true);
                    tmp.AppendLine();
                    idx++;
                }
                this.Value = tmp.ToString();
                this.Size = idx - 1;
            }
        }
    }
    /// <summary>
    /// 3.16.2对应收款人信息
    /// </summary>
    public class PayeeInfo_3_16_2
    {
        /// <summary>
        /// 订单号，最大32位，必须唯一不可重复	必输
        /// </summary>
        public string OrderNo { get; set; }
        /// <summary>
        /// 二级商户名称，最大60位	非必输
        /// </summary>
        public string MerchantName { get; set; }
        /// <summary>
        /// 收款账号  最长32位	必输
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 收款人名称	最长120位	必输
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 收款银行人行支付行号	最长14位	必输
        /// </summary>
        public string BankCode { get; set; }
        /// <summary>
        /// 对方账户类型	最长1位	必输，0－储蓄卡 1－信用卡 2-企业账户
        /// </summary>
        public int AccountType { get; set; }
        /// <summary>
        /// 收款银行人行支付行名	最长120位	跨行支付必输
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 金额	Decimal(17,2)	必输
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 用途	最长60位	必输
        /// </summary>
        public string Purpose { get; set; }
    }
}
