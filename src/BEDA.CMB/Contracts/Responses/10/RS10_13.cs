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
    /// 10.13.利息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_13 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTCININQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCININQ";
        /// <summary>
        /// 10.13.利息查询响应集合
        /// </summary>
        [XmlElement("NTCININQZ")]
        public List<NTCININQZ> List { get; set; }
    }
    /// <summary>
    /// 10.13.利息查询响应内容
    /// </summary>
    public class NTCININQZ
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	N(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 帐户类型	C(3)	A.29 帐户类型   人民币现金池为空
        /// </summary>
        public string CACTYP { get; set; }
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 利息收入	M
        /// </summary>
        public decimal RCVAMT { get; set; }
        /// <summary>
        /// 利息支出	M
        /// </summary>
        public decimal PAYAMT { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
