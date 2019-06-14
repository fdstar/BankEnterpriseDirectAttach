using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 对私付款-对账文件下载响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLUPRDWN : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<PrivatePaymentDownload> List { get; set; }
    }
    /// <summary>
    /// 对私付款-对账文件下载
    /// </summary>
    public class PrivatePaymentDownload
    {
        /// <summary>
        /// 对账日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime QryDate { get; set; }
        /// <summary>
        /// 对账日期 char(8)，格式YYYYMMDD, 对应<see cref="QryDate"/>
        /// </summary>
        [XmlElement("qryDate")]
        public string QryDateStr
        {
            get
            {
                return this.QryDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QryDate = tmp;
                }
            }
        }
        /// <summary>
        /// 付款账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 对账文件名 varchar(60)
        /// </summary>
        [XmlElement("fileName")]
        public string FileName { get; set; }
        /// <summary>
        /// 对账文件内容 varchar(1048576)，需用base64解码后再进行zip解压缩
        /// </summary>
        [XmlElement("fileContent")]
        public PrivatePaymentFileContent FileContent { get; set; }
    }
    /// <summary>
    /// 对私付款-对账文件字符串格式
    /// </summary>
    public class PrivatePaymentFileContent : FileContent
    {
        /// <summary>
        /// 将银行格式的字符串转化成数据实体
        /// </summary>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public PrivatePaymentRecSummary GetSummary(Encoding encoding = null)
        {
            PrivatePaymentRecSummary summary = null;
            var content = this.GetContent(encoding);
            if (!string.IsNullOrWhiteSpace(content))
            {
                var tmp = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                var summArr = tmp[0].Split(',');
                summary = new PrivatePaymentRecSummary
                {
                    SuccessAmount = decimal.Parse(summArr[0]),
                    SuccessCount = int.Parse(summArr[1]),
                    FailureCount = int.Parse(summArr[2]),
                    List = tmp.Skip(1)
                    .Select(x =>
                    {
                        var arr = x.Split(',');
                        DateTime.TryParseExact(arr[12], "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime settleDate);
                        return new PrivatePaymentReconciliation
                        {
                            ClientID = arr[0],
                            TransactionDate = DateTime.ParseExact(arr[1], "yyyyMMdd", CultureInfo.CurrentCulture),
                            TransactionType = int.Parse(arr[2]),
                            ID = int.Parse(arr[3]),
                            AccountNo = arr[4],
                            AccountName = arr[5],
                            TransactionAmount = decimal.Parse(arr[6]),
                            Currency = arr[7],
                            OriginalTransNo = arr[8],
                            OriginalTransDate = arr[9],
                            Status = int.Parse(arr[10]),
                            FailureReason = arr[11],
                            SettleDate = settleDate,
                            Field1 = arr[13],
                        };
                    }).ToList()
                };
            }
            return summary;
        }
    }
    /// <summary>
    /// 对私付款-对账汇总
    /// </summary>
    public class PrivatePaymentRecSummary
    {
        /// <summary>
        /// 成功金额	decimal(15,2) 
        /// </summary>
        public decimal SuccessAmount { get; set; }
        /// <summary>
        /// 成功记录数	int(6)
        /// </summary>
        public int SuccessCount { get; set; }
        /// <summary>
        /// 失败记录数	int(6)
        /// </summary>
        public int FailureCount { get; set; }
        /// <summary>
        /// 对账记录集合
        /// </summary>
        public List<PrivatePaymentReconciliation> List { get; set; }
    }
    /// <summary>
    /// 对私付款-对账
    /// </summary>
    public class PrivatePaymentReconciliation
    {
        /// <summary>
        /// 商户流水号	Char(32)	单笔实时报文中商户流水号
        /// </summary>
        public string ClientID { get; set; }
        /// <summary>
        /// 交易日期	Char(8)
        /// </summary>
        public DateTime TransactionDate { get; set; }
        /// <summary>
        /// 交易类型 Char(1)	1-	代收 2-	代付
        /// </summary>
        public int TransactionType { get; set; }
        /// <summary>
        /// 交易序号	Char(5)	批量报文中交易序号，单笔赋值为空
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 账号	varchar(32)
        /// </summary>
        public string AccountNo { get; set; }
        /// <summary>
        /// 户名	varchar(122)
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// 交易金额	decimal(15,2) 以元为单位
        /// </summary>
        public decimal TransactionAmount { get; set; }
        /// <summary>
        /// 交易货币代码	Char(3)
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 原流水号	Char(8)	预留，暂时不处理
        /// </summary>
        public string OriginalTransNo  { get; set; }
        /// <summary>
        /// 原交易日期	Char(12)	预留，暂时不处理
        /// </summary>
        public string OriginalTransDate { get; set; }
        /// <summary>
        /// 处理状态	Char(4)	
        /// 0-初始状态
        /// 1-核心记账成功
        /// 2-核心记账失败
        /// 3-银联记账成功
        /// 4-银联记账失败
        /// 5-银联状态未知
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 失败原因	Char(60)
        /// </summary>
        public string FailureReason { get; set; }
        /// <summary>
        /// 机构清算日期	Char(10)	主机账务日期（他行代收付业务以清算资金到账日期为账务日期）格式2016-04-29
        /// </summary>
        public DateTime SettleDate { get; set; }
        /// <summary>
        /// 预留字段1	varchar (30)	对应经办交易录入的预留字段1
        /// </summary>
        public string Field1 { get; set; }
    }
}
