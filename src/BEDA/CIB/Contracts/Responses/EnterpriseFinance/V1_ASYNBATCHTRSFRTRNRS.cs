using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 异步批量支付 (最多100笔，不采用工作流) 响应主体
    /// </summary>
    public class V1_ASYNBATCHTRSFRTRNRS : IResponse
    {
        /// <summary>
        /// 异步批量支付 (最多100笔，不采用工作流) 响应
        /// </summary>
        public ASYNBATCHTRSFRTRNRS ASYNBATCHTRSFRTRNRS { get; set; }
    }
    /// <summary>
    /// 异步批量支付 (最多100笔，不采用工作流) 响应
    /// </summary>
    public class ASYNBATCHTRSFRTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 异步批量支付 (最多100笔，不采用工作流) 响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ASYNBATCHTRSFRTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 异步批量支付 (最多100笔，不采用工作流) 响应内容
    /// </summary>
    public class ASYNBATCHTRSFRTRN_RSBODY : Requests.ASYNBATCHTRSFRTRN
    {
        /// <summary>
        /// 批量收款人列表，最多100笔
        /// </summary>
        [XmlElement("XFERINFOTEXT", Order = 9)]
        public RS_XFERINFOTEXT XFERINFOTEXT { get; set; }
        /// <summary>
        /// 批量指令处理状态
        /// </summary>
        [XmlElement(Order = 10)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 收款处理列表
    /// </summary>
    [XmlRoot("XFERINFOTEXT")]
    public class RS_XFERINFOTEXT : Requests.XFERINFOTEXT<PayResult>
    {
        /// <summary>
        /// 获取<see cref="Requests.XFERINFOTEXT{T}.Value"/>对应的数据集合
        /// </summary>
        /// <returns></returns>
        public override IList<PayResult> GetList()
        {
            IList<PayResult> list = null;
            if (this.Value != null && this.Value.Length > 10)
            {
                var tmpArr = this.Value.Split('|');
                int cols = 13;
                if (tmpArr.Length >= cols)
                {
                    list = new List<PayResult>();
                    for (var i = 0; i < tmpArr.Length / cols; i++)
                    {
                        Enum.TryParse(this.GetString(tmpArr[i * cols + 11]), out XFERPRCCODEEnum status);
                        var result = new PayResult
                        {
                            Account = this.GetString(tmpArr[i * cols + 1]),
                            Name = this.GetString(tmpArr[i * cols + 2]),
                            IsCIB = this.GetString(tmpArr[i * cols + 3])[0],
                            IsSameCity = this.GetString(tmpArr[i * cols + 4])[0],
                            BankCode = this.GetString(tmpArr[i * cols + 5]),
                            BankName = this.GetString(tmpArr[i * cols + 6]),
                            Address = this.GetString(tmpArr[i * cols + 7]),
                            Amount = decimal.Parse(this.GetString(tmpArr[i * cols + 8])),
                            Purpose = this.GetString(tmpArr[i * cols + 9]),
                            Remark = this.GetString(tmpArr[i * cols + 10]),
                            Status = status,
                            ResultMsg = this.GetString(tmpArr[i * cols + 12]),
                        };
                        list.Add(result);
                    }
                }
            }
            return list;
        }
        private string GetString(string str)
        {
            return str.Trim();
        }
        /// <summary>
        /// 响应时不支持该方法
        /// </summary>
        /// <param name="source"></param>
        public override void SetList(IEnumerable<PayResult> source)
        {
            throw new NotSupportedException();
        }
    }
    /// <summary>
    /// 收款处理结果
    /// </summary>
    public class PayResult : Requests.PayeeInfo
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
