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
    /// 12.2.6.支付机构查询实时汇率响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_2_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTEXRQAB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXRQAB";
        /// <summary>
        /// 12.2.6.支付机构查询实时汇率响应集合
        /// </summary>
        [XmlElement("NTRATEXRZ")]
        public List<NTRATEXRZ> List { get; set; }
    }
    /// <summary>
    /// 12.2.6.支付机构查询实时汇率响应内容
    /// </summary>
    public class NTRATEXRZ
    {
        /// <summary>
        /// 交易货币 	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 计价货币 	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYEXC { get; set; }
        /// <summary>
        /// 汇率基数 	N(5)
        /// </summary>
        public int RATBAS { get; set; }
        /// <summary>
        /// 现汇买价 	F(11,7)
        /// </summary>
        public decimal RTHBID { get; set; }
        /// <summary>
        /// 现汇卖价 	F(11,7)
        /// </summary>
        public decimal RTHOFR { get; set; }
        /// <summary>
        /// 汇率状态 	C(1)	Y;正常N不可交易
        /// </summary>
        public string RATSTS { get; set; }
        /// <summary>
        /// 汇率日期 	D
        /// </summary>
        public string RATDAT { get; set; }
        /// <summary>
        /// 汇率时间	T
        /// </summary>
        public string RATTIM { get; set; }
        /// <summary>
        /// 汇率时间 由<see cref="RATDAT"/>和<see cref="RATTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? RateTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.RATDAT, this.RATTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 汇率位数	N(1)
        /// </summary>
        public int RATPNT { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
