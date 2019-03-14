using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 2.3.查询账户交易信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ2_3 : CMBBase<RQINFO>, IRequest<RS2_3>
    {
        /// <summary>
        /// GetTransInfo
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetTransInfo";
        /// <summary>
        /// 2.3.查询账户交易信息请求内容
        /// </summary>
        public SDKTSINFX SDKTSINFX { get; set; }
    }
    /// <summary>
    /// 2.3.查询账户交易信息请求内容
    /// </summary>
    public class SDKTSINFX
    {
        /// <summary>
        /// 分行号	N(2)	附录A.1   分行号和分行名称不能同时为空
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 分行名称	Z(1,62)	附录A.1
        /// </summary>
        public string C_BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(1,35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 开始日期	D  开始日期和结束日期的间隔不能超过100天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 开始日期	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D  开始日期和结束日期的间隔不能超过100天
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 最小金额	M   默认0.00
        /// </summary>
        public decimal? LOWAMT { get; set; }
        /// <summary>
        /// 最大金额	M   默认9999999999999.99
        /// </summary>
        public decimal? HGHAMT { get; set; }
        /// <summary>
        /// 借贷码	C(1)	C：收入 D：支出
        /// </summary>
        public string AMTCDR { get; set; }
    }
}
