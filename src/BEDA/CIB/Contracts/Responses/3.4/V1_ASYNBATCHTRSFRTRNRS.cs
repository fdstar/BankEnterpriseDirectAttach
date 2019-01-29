using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.12异步批量支付 (最多100笔，不采用工作流) 响应主体
    /// </summary>
    public class V1_ASYNBATCHTRSFRTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.12异步批量支付 (最多100笔，不采用工作流) 响应
        /// </summary>
        public ASYNBATCHTRSFRTRNRS ASYNBATCHTRSFRTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.12异步批量支付 (最多100笔，不采用工作流) 响应
    /// </summary>
    public class ASYNBATCHTRSFRTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.4.12异步批量支付 (最多100笔，不采用工作流) 响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ASYNBATCHTRSFRTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.4.12异步批量支付 (最多100笔，不采用工作流) 响应内容
    /// </summary>
    public class ASYNBATCHTRSFRTRN_RSBODY : Requests.ASYNBATCHTRSFRTRN
    {
        /// <summary>
        /// 批量收款人列表，最多100笔
        /// </summary>
        [XmlElement("XFERINFOTEXT", Order = 9)]
        public ASYNBATCHTRSFRTRNRS_XFERINFOTEXT XFERINFOTEXT { get; set; }
        /// <summary>
        /// 批量指令处理状态
        /// </summary>
        [XmlElement(Order = 10)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 3.4.12收款处理列表
    /// </summary>
    [XmlRoot("XFERINFOTEXT")]
    public class ASYNBATCHTRSFRTRNRS_XFERINFOTEXT : Requests.XFERINFOTEXT<PayResult_3_4_12>
    {
        /// <summary>
        /// 获取接口格式对应的数据集合
        /// 请求时 格式为  序号|收款账号|收款人名称|是否兴业银行|是否同城|收款银行行号|收款行名称|收款地址|金额|用途|备注|
        /// 响应时 格式为  序号|收款账号|收款人名称|是否兴业银行|是否同城|收款银行行号|收款行名称|收款地址|金额|用途|备注|处理状态|处理结果信息|
        /// 需保证明细中每个字段值不含‘|’，否则将引起系统解析异常
        /// </summary>
        /// <returns></returns>
        public override IList<PayResult_3_4_12> GetList()
        {
            IList<PayResult_3_4_12> list = null;
            if (this.Value != null && this.Value.Length > 10)
            {
                var tmpArr = this.Value.Split('|');
                int cols = 13;
                if (tmpArr.Length >= cols)
                {
                    list = new List<PayResult_3_4_12>();
                    for (var i = 0; i < tmpArr.Length / cols; i++)
                    {
                        Enum.TryParse(this.GetTrimedString(tmpArr[i * cols + 11]), out XFERPRCCODEEnum status);
                        var result = new PayResult_3_4_12
                        {
                            Account = this.GetTrimedString(tmpArr[i * cols + 1]),
                            Name = this.GetTrimedString(tmpArr[i * cols + 2]),
                            IsCIB = this.GetTrimedString(tmpArr[i * cols + 3])[0],
                            IsSameCity = this.GetTrimedString(tmpArr[i * cols + 4])[0],
                            BankCode = this.GetTrimedString(tmpArr[i * cols + 5]),
                            BankName = this.GetTrimedString(tmpArr[i * cols + 6]),
                            Address = this.GetTrimedString(tmpArr[i * cols + 7]),
                            Amount = decimal.Parse(this.GetTrimedString(tmpArr[i * cols + 8])),
                            Purpose = this.GetTrimedString(tmpArr[i * cols + 9]),
                            Remark = this.GetTrimedString(tmpArr[i * cols + 10]),
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
        public override void SetList(IEnumerable<PayResult_3_4_12> source)
        {
            throw new NotSupportedException();
        }
    }
    /// <summary>
    /// 收款处理结果
    /// </summary>
    public class PayResult_3_4_12 : Requests.PayeeInfo_3_4_12
    {
        /// <summary>
        /// 最长30位	值为：
        /// SUBMIT_SUCC-已提交成功
        /// EXPIRED-过期
        /// FAIL-交易失败
        /// PAYOUT-交易成功
        /// PENDING-结果未知
        /// PART_PAYOUT-部分成功
        /// </summary>
        public XFERPRCCODEEnum Status { get; set; }
        /// <summary>
        /// 处理结果信息	最长60位	中文处理信息
        /// </summary>
        public string ResultMsg { get; set; }
    }
}
