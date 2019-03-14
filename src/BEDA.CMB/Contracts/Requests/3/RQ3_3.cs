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
    /// 3.3.支付结果列表查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ3_3 : CMBBase<RQINFO>, IRequest<RS3_3>
    {
        /// <summary>
        /// NTQRYSTN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYSTN";
        /// <summary>
        /// 3.3.支付结果列表查询请求内容
        /// </summary>
        public NTQRYSTNY1 NTQRYSTNY1 { get; set; }
    }
    /// <summary>
    /// 3.3.支付结果列表查询请求内容
    /// </summary>
    public class NTQRYSTNY1
    {
        /// <summary>
        /// 业务类别	C(6)	为下列之一： N02020: 内部转帐 N02030: 支付 N02031: 直接支付 N02040: 集团支付 N02041: 直接集团支付
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// 指定的单一模式 如00001
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 起始日期	D   起始结束日期间隔不可超过一周
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
        /// 结束日期	D   起始结束日期间隔不可超过一周
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
        /// 日期类型	C(1)    默认为A
        /// A：经办日期； B：期望日期  
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 保留字50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
