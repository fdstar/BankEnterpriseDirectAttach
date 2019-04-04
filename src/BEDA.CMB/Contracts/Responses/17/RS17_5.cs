using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 17.5.记账宝交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDTHQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDTHQRY";
        /// <summary>
        /// 17.5.记账宝交易查询响应集合
        /// </summary>
        [XmlElement("NTDTHQRYZ")]
        public List<NTDTHQRYZ> List { get; set; }
    }
    /// <summary>
    /// 17.5.记账宝交易查询响应内容
    /// </summary>
    public class NTDTHQRYZ
    {
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 记账流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 交易方向	C(1)	D-借方（支出） C-贷方（收入）
        /// </summary>
        public string TRXDIR { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        public string TRXDAT { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string TRXTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TRXDAT"/>和<see cref="TRXTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRXDAT, this.TRXTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 记账方式	C(1)	交易关联虚拟户的方式：1：自动 2：手工 3：内部转账
        /// </summary>
        public string AUTFLG { get; set; }
        /// <summary>
        /// 收方/付方账号	C(35)   与交易方向对应 交易方向为D时，这里为收方信息； 交易方向为C时，这里为付方信息。
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 收方/付方名称	Z(62)   与交易方向对应 交易方向为D时，这里为收方信息； 交易方向为C时，这里为付方信息。
        /// </summary>
        public string RPYNAM { get; set; }
        /// <summary>
        /// 交易摘要	Z(42)
        /// </summary>
        public string TRXTXT { get; set; }
        /// <summary>
        /// 原内部编号	C(20)	交易识别内部编号，对应虚拟户编号，可能为空
        /// </summary>
        public string NARINN { get; set; }
    }
}
