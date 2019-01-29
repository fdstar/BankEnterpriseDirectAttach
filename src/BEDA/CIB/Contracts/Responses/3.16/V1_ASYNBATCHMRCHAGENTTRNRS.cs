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
    /// 3.16.2收付直通车批量代付(最多100笔，不采用工作流)响应主体
    /// </summary>
    public class V1_ASYNBATCHMRCHAGENTTRNRS : IResponse
    {
        /// <summary>
        /// 3.16.2收付直通车批量代付(最多100笔，不采用工作流)响应主体
        /// </summary>
        public ASYNBATCHMRCHAGENTTRNRS ASYNBATCHMRCHAGENTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.16.2收付直通车批量代付(最多100笔，不采用工作流)响应主体
    /// </summary>
    public class ASYNBATCHMRCHAGENTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.16.2收付直通车批量代付(最多100笔，不采用工作流)响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ASYNBATCHMRCHAGENTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.16.2收付直通车批量代付(最多100笔，不采用工作流)响应内容
    /// </summary>
    public class ASYNBATCHMRCHAGENTTRN_RSBODY
    {
        /// <summary>
        /// 批量指令标题，30位	非必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string TITLE { get; set; }
        /// <summary>
        /// 网银跟踪号	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string SRVRTID { get; set; }
        /// <summary>
        /// 凭证号 9位数字	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 总笔数	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT { get; set; }
        /// <summary>
        /// 货币符号，默认为RMB（目前仅支持人民币）	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string CURSYM { get; set; }
        /// <summary>
        /// 总金额	非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? TOTALAMOUNT { get; set; }
        /// <summary>
        /// 商户代号 最大8位 (商户、个人或外围系统在收付直通车系统开立的商户代号)	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string MRCHNO { get; set; }
        /// <summary>
        /// 付款人账户信息 必回
        /// </summary>
        [XmlElement(Order = 7)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 批量用途，最大60位	非必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 批量备注，最大60位	非必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string MEMO { get; set; }
        /// <summary>
        /// 期望转账日期yyyy-MM-dd 非必回
        /// </summary>
        [XmlIgnore]
        public DateTime? EXPECT_DATE { get; set; }
        /// <summary>
        /// 期望转账日期yyyy-MM-dd, 对应<see cref="EXPECT_DATE"/>	非必回
        /// </summary>
        [XmlElement("EXPECT_DATE", Order = 10)]
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
        [XmlElement("XFERINFOTEXT", Order = 11)]
        public ASYNBATCHMRCHAGENTTRNRS_XFERINFOTEXT XFERINFOTEXT { get; set; }
        /// <summary>
        /// 批量指令处理状态
        /// </summary>
        [XmlElement(Order = 12)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 3.16.2收款处理列表
    /// </summary>
    [XmlRoot("XFERINFOTEXT")]
    public class ASYNBATCHMRCHAGENTTRNRS_XFERINFOTEXT : Requests.XFERINFOTEXT<PayResult_3_16_2>
    {
        /// <summary>
        /// 获取接口格式对应的数据集合
        /// 请求时 格式为  序号|收款账号|收款人名称|是否兴业银行|是否同城|收款银行行号|收款行名称|收款地址|金额|用途|备注|
        /// 响应时 格式为  序号|收款账号|收款人名称|是否兴业银行|是否同城|收款银行行号|收款行名称|收款地址|金额|用途|备注|处理状态|处理结果信息|
        /// 需保证明细中每个字段值不含‘|’，否则将引起系统解析异常
        /// </summary>
        /// <returns></returns>
        public override IList<PayResult_3_16_2> GetList()
        {
            IList<PayResult_3_16_2> list = null;
            if (this.Value != null && this.Value.Length > 10)
            {
                var tmpArr = this.Value.Split('|');
                int cols = 13;
                if (tmpArr.Length >= cols)
                {
                    list = new List<PayResult_3_16_2>();
                    for (var i = 0; i < tmpArr.Length / cols; i++)
                    {
                        Enum.TryParse(this.GetTrimedString(tmpArr[i * cols + 11]), out XFERPRCCODEEnum status);
                        decimal.TryParse(this.GetTrimedString(tmpArr[i * cols + 10]),out decimal fee);
                        var result = new PayResult_3_16_2
                        {
                            OrderNo = this.GetTrimedString(tmpArr[i * cols + 1]),
                            MerchantName = this.GetTrimedString(tmpArr[i * cols + 2]),
                            Account = this.GetTrimedString(tmpArr[i * cols + 3]),
                            Name = this.GetTrimedString(tmpArr[i * cols + 4]),
                            BankCode = this.GetTrimedString(tmpArr[i * cols + 5]),
                            AccountType = int.Parse(this.GetTrimedString(tmpArr[i * cols + 6])),
                            BankName = this.GetTrimedString(tmpArr[i * cols + 7]),
                            Amount = decimal.Parse(this.GetTrimedString(tmpArr[i * cols + 8])),
                            Purpose = this.GetTrimedString(tmpArr[i * cols + 9]),
                            Fee = fee,
                            Status = status,
                            ResultMsg = this.GetTrimedString(tmpArr[i * cols + 12]),
                        };
                        list.Add(result);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 响应时不支持该方法
        /// </summary>
        /// <param name="source"></param>
        public override void SetList(IEnumerable<PayResult_3_16_2> source)
        {
            throw new NotSupportedException();
        }
    }
    /// <summary>
    /// 3.16.2收款处理结果
    /// </summary>
    public class PayResult_3_16_2 : Requests.PayeeInfo_3_16_2
    {
        /// <summary>
        /// 手续费	Decimal(17,2)
        /// </summary>
        public decimal Fee { get; set; }
        /// <summary>
        /// 最长30位	值为：
        /// PROCESSING -后台处理中（需再次查询）
        /// PENDING-结果未知（需再次查询）
        /// FAIL-交易失败
        /// PAYOUT-交易成功
        /// EXPIRED-过期
        /// </summary>
        public XFERPRCCODEEnum Status { get; set; }
        /// <summary>
        /// 处理结果信息	最长60位	中文处理信息
        /// </summary>
        public string ResultMsg { get; set; }
    }
}
