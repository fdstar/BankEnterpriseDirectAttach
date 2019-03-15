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
    /// 21.1.5.业务总揽查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_1_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQNPEBP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQNPEBP";
        /// <summary>
        /// 21.1.5.业务总揽查询响应集合
        /// </summary>
        [XmlElement("NTQNPEBPZ")]
        public List<NTQNPEBPZ> List { get; set; }
    }
    /// <summary>
    /// 21.1.5.业务总揽查询响应内容
    /// </summary>
    public class NTQNPEBPZ
    {
        /// <summary>
        /// NP交易流水号	C(11)	
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 交易方向	C(1)	I：提回 O：提出
        /// </summary>
        public string TRXDIR { get; set; }
        /// <summary>
        /// 业务种类	C(3)	101：网银贷记 103：网银借记 105：第三方贷记
        /// </summary>
        public string MSGNBR { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRXDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRXDAT"/>
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
        /// 交易状态	C(2)	附录 A.48
        /// </summary>
        public string TRXSTS { get; set; }
        /// <summary>
        /// 交易货币	C(2)	附录 A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 付款人账号	C(35)
        /// </summary>
        public string PYREAC { get; set; }
        /// <summary>
        /// 付款人名称	Z(100)
        /// </summary>
        public string PYRNAM { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string PYEEAC { get; set; }
        /// <summary>
        /// 收款人名称	Z(100)
        /// </summary>
        public string PYENAM { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 内部协议号	C(10)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 保留字 30	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
