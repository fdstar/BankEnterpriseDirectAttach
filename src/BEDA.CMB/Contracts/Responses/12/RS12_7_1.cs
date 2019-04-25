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
    /// 12.7.1.直联版支付机构汇率查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_7_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTPBRQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPBRQRY";
        /// <summary>
        /// 12.7.1.直联版支付机构汇率查询响应集合
        /// </summary>
        [XmlElement("NTPBRINFZ")]
        public List<NTPBRINFZ> List { get; set; }
    }
    /// <summary>
    /// 12.7.1.直联版支付机构汇率查询响应内容
    /// </summary>
    public class NTPBRINFZ
    {
        /// <summary>
        /// 交易货币	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 计价货币	C(2)	附录A.3
        /// </summary>
        public string CCYEXC { get; set; }
        /// <summary>
        /// 汇率基数（交易币单位）	F(5,0)
        /// </summary>
        public int RATBAS { get; set; }
        /// <summary>
        /// 现汇买入价	F(11,7)	
        /// </summary>
        public decimal RTHBID { get; set; }
        /// <summary>
        /// 现汇卖出价	F(11,7)
        /// </summary>
        public decimal RTHOFR { get; set; }
        /// <summary>
        /// 汇率日期	D
        /// </summary>
        public string RATDAT { get; set; }
        /// <summary>
        /// 汇率时间	F(6,0)
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
        /// 汇率状态	C(1)	A:正常 N:不可交易 S:停止
        /// </summary>
        public string RATSTS { get; set; }
        /// <summary>
        /// 保留价格1	F(11,7)
        /// </summary>
        public decimal? RSVRT1 { get; set; }
        /// <summary>
        /// 保留价格2	F(11,7)
        /// </summary>
        public decimal? RSVRT2 { get; set; }
    }
}
