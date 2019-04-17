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
    /// 8.2.6.智能现金池基金个性化查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_2_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNPATR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPATR";
        /// <summary>
        /// 8.2.6.智能现金池基金个性化查询响应内容
        /// </summary>
        public NTFNPATRZ NTFNPATRZ { get; set; }
    }
    /// <summary>
    /// 8.2.6.智能现金池基金个性化查询响应内容
    /// </summary>
    public class NTFNPATRZ
    {
        /// <summary>
        /// 交易单位      	C(8) 
        /// </summary>
        public string TRSNIT { get; set; }
        /// <summary>
        /// 定期投资单笔交易上限  	M
        /// </summary>
        public decimal? UPRLMT { get; set; }
        /// <summary>
        /// 定期投资单笔交易下限  	M
        /// </summary>
        public decimal? LOWLMT { get; set; }
        /// <summary>
        /// 协议状态      	C(1) 	A-正常，B-暂停，C-关闭
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 持有下限      	M
        /// </summary>
        public decimal? LOWOWN { get; set; }
        /// <summary>
        /// 定期定额周期  	C(4) 
        /// </summary>
        public string FNPTUN { get; set; }
        /// <summary>
        /// 基金当前交易日	C(8) 
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDAT { get; set; }
        /// <summary>
        /// 基金当前交易日	C(8), 对应<see cref="TRSDAT"/>
        /// </summary>
        [XmlElement("TRSDAT")]
        public string TRSDATStr
        {
            get
            {
                return this.TRSDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDAT = tmp;
                }
            }
        }
    }
}
