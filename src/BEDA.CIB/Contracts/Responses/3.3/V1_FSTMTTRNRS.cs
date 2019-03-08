using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.3.9账户交易流水文件查询响应主体
    /// </summary>
    public class V1_FSTMTTRNRS : IResponse
    {
        /// <summary>
        /// 3.3.9账户交易流水文件查询响应
        /// </summary>
        public FSTMTTRNRS FSTMTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.3.9账户交易流水文件查询响应
    /// </summary>
    public class FSTMTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE，非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 3.3.9流水响应内容
        /// </summary>
        [XmlElement(Order = 3)]
        public FSTMTTRN_SCUSTSTMTRS SCUSTSTMTRS { get; set; }
    }
    /// <summary>
    /// 3.3.9流水响应内容
    /// </summary>
    public class FSTMTTRN_SCUSTSTMTRS
    {
        /// <summary>
        /// 付款人账户，非必回
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 流水总笔数，非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public int? TOTAL { get; set; }
        /// <summary>
        /// Y-还有下页流水，N-无下页流水，非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string MORE { get; set; }
        /// <summary>
        /// 3.3.9账户交易流水文件定长明细
        /// </summary>
        [XmlElement(Order = 3)]
        public FSTMTTRN_TRANLIST TRANLIST { get; set; }
        /// <summary>
        /// 活期账户余额，和下面可用余额基本一致，除非存在贷款户等业务上冻结或被控制的金额，总账才会比可用大。
        /// </summary>
        [XmlElement(Order = 4)]
        public BALANCE LEDGERBAL { get; set; }
        /// <summary>
        /// 可用余额
        /// </summary>
        [XmlElement(Order = 5)]
        public BALANCE AVAILBAL { get; set; }
    }
    /// <summary>
    /// 3.3.9账户交易流水文件定长明细
    /// </summary>
    [XmlRoot("TRANLIST")]
    public class FSTMTTRN_TRANLIST
    {
        private IList<TransactionDetail> _details;
        /// <summary>
        /// 数量
        /// </summary>
        [XmlAttribute("size")]
        public int Size { get; set; }
        /// <summary>
        /// 账户交易流水文件定长明细
        /// </summary>
        [XmlText]
        public string Value { get; set; }
        /// <summary>
        /// 获取<see cref="Value"/>对应的交易明细
        /// </summary>
        /// <returns></returns>
        public IList<TransactionDetail> GetDetails()
        {
            if (!string.IsNullOrWhiteSpace(this.Value))
            {
                if (this._details == null)
                {
                    var list = new List<TransactionDetail>();
                    var sIdx = 0;
                    while (sIdx < this.Value.Length)
                    {
                        this.TranslateEmptyContent(ref sIdx);
                        if (sIdx >= this.Value.Length)
                        {
                            break;
                        }
                        var detail = new TransactionDetail();
                        this.TranslateContent(ref sIdx, 30, s => detail.CoreSn = s.Trim());
                        this.TranslateContent(ref sIdx, 10, s => detail.GroupSn = s.Trim());
                        this.TranslateContent(ref sIdx, 3, s => detail.GroupInnerSn = s.Trim());
                        this.TranslateContent(ref sIdx, 14, s => detail.TransactionTime = DateTime.ParseExact(s, "yyyyMMddHHmmss", CultureInfo.InvariantCulture));
                        this.TranslateContent(ref sIdx, 2, s => detail.AreaCode = s.Trim());
                        this.TranslateContent(ref sIdx, 3, s => detail.OrgCode = s.Trim());
                        this.TranslateContent(ref sIdx, 4, s => detail.TransactionCode = s.Trim());
                        this.TranslateContent(ref sIdx, 4, s => detail.AccountingCode = s.Trim());
                        this.TranslateContent(ref sIdx, 8, s => detail.EmployeeSn = s.Trim());
                        this.TranslateContent(ref sIdx, 3, s => detail.ChannelKind = s.Trim());
                        this.TranslateContent(ref sIdx, 10, s => detail.LocalCertificateCode = s.Trim());
                        this.TranslateContent(ref sIdx, 10, s => detail.CoreCustomerCode = s.Trim());
                        this.TranslateContent(ref sIdx, 15, s => detail.CurrentAccount = decimal.Parse(s.Trim()));
                        this.TranslateContent(ref sIdx, 15, s => detail.TransactionAccont = decimal.Parse(s.Trim()));
                        this.TranslateContent(ref sIdx, 2, s => detail.CurrencyKind = s.Trim());
                        this.TranslateContent(ref sIdx, 1, s => detail.CashFlag = this.ConvertByte(s));
                        this.TranslateContent(ref sIdx, 1, s => detail.LendingFlag = this.ConvertByte(s));
                        this.TranslateContent(ref sIdx, 1, s => detail.SupplementFlag = this.ConvertByte(s));
                        this.TranslateContent(ref sIdx, 1, s => detail.BeSupplementedFlag = this.ConvertByte(s));
                        this.TranslateContent(ref sIdx, 3, s => detail.SummaryCode = s.Trim());
                        this.TranslateContent(ref sIdx, 32, s => detail.CorrelateCertificateCode = s.Trim());
                        this.TranslateContent(ref sIdx, 32, s => detail.CorrelateAccountNumber = s.Trim());
                        this.TranslateContent(ref sIdx, 120, s => detail.CorrelateAccountName = s.Trim(), true);
                        this.TranslateContent(ref sIdx, 14, s => detail.CorrelateBankNumber = s.Trim());
                        this.TranslateContent(ref sIdx, 70, s => detail.CorrelateBankName = s.Trim(), true);
                        this.TranslateContent(ref sIdx, 1, s => detail.RouteChoice = this.ConvertByte(s));
                        this.TranslateContent(ref sIdx, 60, s => detail.Purpose = s.Trim(), true);
                        this.TranslateContent(ref sIdx, 60, s => detail.Memo = s.Trim(), true);
                        this.TranslateContent(ref sIdx, 1, _ => { });
                        list.Add(detail);
                    }//30,10,3,8,6,2,3,4, 4,8,3,10,10,15,15, 2,1,1,1,1,3,32,32,120,14,70,1,60,60,1
                    this._details = list;
                }
            }
            return _details;
        }
        private byte? ConvertByte(string input)
        {
            if (byte.TryParse(input, out byte data))
            {
                return data;
            }
            return null;
        }
        private void TranslateEmptyContent(ref int startIndex)
        {
            var emptyArr = new char[] { ' ', '\n', '\r' };
            while (startIndex < this.Value.Length
                && emptyArr.Contains(this.Value[startIndex]))
            {
                startIndex++;
            }
        }
        private void TranslateContent(ref int startIndex, int length, Action<string> act, bool checkSingle = false)
        {
            var subStr = this.Value.Substring(startIndex, length);
            if (checkSingle)
            {
                var singleLength = Utils.StringExtensions.GetSingleLength(subStr);
                if (singleLength > length)
                {
                    length = length * 2 - singleLength;
                    subStr = this.Value.Substring(startIndex, length);
                }
            }
            startIndex += length;
            act(subStr);
        }
        /// <summary>
        /// 交易明细
        /// </summary>
        public class TransactionDetail
        {
            /// <summary>
            /// 核心交易流水编号，长度30，具备唯一性
            /// </summary>
            public string CoreSn { get; set; }
            /// <summary>
            /// 传票组序号，长度10
            /// </summary>
            public string GroupSn { get; set; }
            /// <summary>
            /// 传票组内序号，长度3
            /// </summary>
            public string GroupInnerSn { get; set; }
            /// <summary>
            /// 交易日期，长度8 + 交易时间，长度6
            /// </summary>
            public DateTime TransactionTime { get; set; }
            /// <summary>
            /// 本行交易地区代号，长度2
            /// </summary>
            public string AreaCode { get; set; }
            /// <summary>
            /// 本行交易机构代号，长度3
            /// </summary>
            public string OrgCode { get; set; }
            /// <summary>
            /// 交易代码，长度4
            /// </summary>
            public string TransactionCode { get; set; }
            /// <summary>
            /// 记账交易代码，长度4
            /// </summary>
            public string AccountingCode { get; set; }
            /// <summary>
            /// 柜员流水号，长度8
            /// </summary>
            public string EmployeeSn { get; set; }
            /// <summary>
            /// 渠道种类，长度3
            /// </summary>
            public string ChannelKind { get; set; }
            /// <summary>
            /// 本行凭证代号，长度10
            /// </summary>
            public string LocalCertificateCode { get; set; }
            /// <summary>
            /// 核心客户代号，长度10
            /// </summary>
            public string CoreCustomerCode { get; set; }
            /// <summary>
            /// 账户当前余额，长度15，含2位小数
            /// </summary>
            public decimal CurrentAccount { get; set; }
            /// <summary>
            /// 交易金额，长度15，含2位小数
            /// </summary>
            public decimal TransactionAccont { get; set; }
            /// <summary>
            /// 货币种类，长度2，01人民币
            /// </summary>
            public string CurrencyKind { get; set; }
            /// <summary>
            /// 现转标志，0-现金 1-转账
            /// </summary>
            public byte? CashFlag { get; set; }
            /// <summary>
            /// 借贷标记，0-借方 1-贷方
            /// </summary>
            public byte? LendingFlag { get; set; }
            /// <summary>
            /// 冲补标志，0 正常 1 当日冲正 2-补帐 3-隔日补账
            /// </summary>
            public byte? SupplementFlag { get; set; }
            /// <summary>
            /// 被冲账标志，0 正常 1 当日被冲正 2-隔日被冲正 3-当日被撤销 4-隔日被撤销
            /// </summary>
            public byte? BeSupplementedFlag { get; set; }
            /// <summary>
            /// 摘要代号，长度3
            /// </summary>
            public string SummaryCode { get; set; }
            /// <summary>
            /// 对方凭证代号，长度32
            /// </summary>
            public string CorrelateCertificateCode { get; set; }
            /// <summary>
            /// 对方账号，长度32
            /// </summary>
            public string CorrelateAccountNumber { get; set; }
            /// <summary>
            /// 对方账户名称，长度120
            /// </summary>
            public string CorrelateAccountName { get; set; }
            /// <summary>
            /// 对方行行号，长度14
            /// </summary>
            public string CorrelateBankNumber { get; set; }
            /// <summary>
            /// 对方行行名，长度70
            /// </summary>
            public string CorrelateBankName { get; set; }
            /// <summary>
            /// 邮路选择，0 同城票交 3-大额实时 4-小额批量 8-跨行
            /// </summary>
            public byte? RouteChoice { get; set; }
            /// <summary>
            /// 用途，长度60
            /// </summary>
            public string Purpose { get; set; }
            /// <summary>
            /// 备注，长度60
            /// </summary>
            public string Memo { get; set; }
        }
    }
}
