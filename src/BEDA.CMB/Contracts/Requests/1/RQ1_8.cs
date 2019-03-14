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
    /// 1.8.查询历史通知 请用1.9查询历史通知（新），此接口不支持大批量数据
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ1_8 : CMBBase<RQINFO>, IRequest<RS1_8>
    {
        /// <summary>
        /// GetHisNotice
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetHisNotice";
        /// <summary>
        /// 1.8.查询历史通知请求内容
        /// </summary>
        public FBDLRHMGX FBDLRHMGX { get; set; }
    }
    /// <summary>
    /// 1.8.查询历史通知请求内容
    /// </summary>
    public class FBDLRHMGX
    {
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
        /// 消息类型	C(8)	附录A.16
        /// NCBCHOPR	批量支付经办结果通知
        /// NCCRTTRS 到帐通知
        /// NCDBTTRS 付款通知
        /// NCDRTPAY 直接支付结果通知
        /// NCBUSFIN 业务完成通知
        /// </summary>
        public string MSGTYP { get; set; }
        /// <summary>
        /// 消息号	C(18)
        /// </summary>
        public string MSGNBR { get; set; }
    }
}
