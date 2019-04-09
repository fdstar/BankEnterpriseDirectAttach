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
    /// 17.13.虚拟户内部转账响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_13 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMATRX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMATRX";
        /// <summary>
        /// 17.13.虚拟户内部转账响应集合
        /// </summary>
        [XmlElement("NTDMATRXZ1")]
        public List<NTDMATRXZ1> List { get; set; }
    }
    /// <summary>
    /// 17.13.虚拟户内部转账响应内容
    /// </summary>
    public class NTDMATRXZ1
    {
        /// <summary>
        /// 记账日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRXDAT { get; set; }
        /// <summary>
        /// 记账日期	D, 对应<see cref="TRXDAT"/>
        /// </summary>
        [XmlElement("TRXDAT")]
        public string TRXDATStr
        {
            get
            {
                return this.TRXDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRXDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 记账流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 交易方向	C(1)	D:付款方 C:收款方
        /// </summary>
        public string TRXDIR { get; set; }
    }
}
