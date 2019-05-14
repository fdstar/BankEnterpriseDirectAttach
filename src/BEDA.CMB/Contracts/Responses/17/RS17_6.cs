using BEDA.Utils;
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
    /// 17.6.手工记账响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTHKPACT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTHKPACT";
        /// <summary>
        /// 17.6.手工记账响应集合
        /// </summary>
        [XmlElement("NTHKPACTZ")]
        public List<NTHKPACTZ> List { get; set; }
    }
    /// <summary>
    /// 17.6.手工记账响应内容
    /// </summary>
    public class NTHKPACTZ
    {
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
        /// 记账流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 关联虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        [XmlIgnore]
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 交易金额	M, 对应<see cref="TRXAMT"/>
        /// </summary>
        [XmlElement("TRXAMT")]
        public string TRXAMTStr
        {
            get
            {
                return this.TRXAMT.ToString();
            }
            set
            {
                this.TRXAMT = value.TryConvert<decimal>() ?? 0;
            }
        }
        /// <summary>
        /// 交易方向	C(1)
        /// </summary>
        public string TRXDIR { get; set; }
        /// <summary>
        /// 处理状态	C(1)	S：成功 F：失败
        /// </summary>
        public string PRCSTS { get; set; }
        /// <summary>
        /// 返回码	C(7)	SUC0000：成功 其他：失败
        /// </summary>
        public string RTNCOD { get; set; }
        /// <summary>
        /// 返回信息	Z(92)   返回码不是 SUC0000时，会返回相关提示信息
        /// </summary>
        public string RTNTXT { get; set; }
    }
}
