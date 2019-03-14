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
    /// 3.11.支付结果列表查询-按业务参考号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ3_11 : CMBBase<RQINFO>, IRequest<RS3_11>
    {
        /// <summary>
        /// NTQRYSTY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYSTY";
        /// <summary>
        /// 3.11.支付结果列表查询-按业务参考号请求内容
        /// </summary>
        public NTQRYSTYX1 NTQRYSTYX1 { get; set; }
    }
    /// <summary>
    /// 3.11.支付结果列表查询-按业务参考号请求内容
    /// </summary>
    public class NTQRYSTYX1
    {
        /// <summary>
        /// 业务类别	C(6)	附录A.4
        /// 为下列之一： N02020: 内部转帐 N02030: 支付 N02031: 直接支付 N02040: 集团支付 N02041: 直接集团支付
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务参考号	C(30)	只查询指定的业务参考号交易（不提供模糊查询）
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 起始日期	D   
        /// 按经办日期查询，起始结束日期间隔不能超过一周 起始日期不可小于当前日期前90天 （日切零点附近的交易若查询不到可尝试跨日查询）
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 结束日期	D
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
    }
}
