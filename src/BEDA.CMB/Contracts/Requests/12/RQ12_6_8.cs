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
    /// 12.6.8.支付机构查询汇款类业务项下子业务上传批次列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_6_8 : CMBBase<RQINFO>, IRequest<RS12_6_8>
    {
        /// <summary>
        /// NTPAYQCL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYQCL";
        /// <summary>
        /// 12.6.8.支付机构查询汇款类业务项下子业务上传批次列表请求内容
        /// </summary>
        public NTPAYQCLY NTPAYQCLY { get; set; }
    }
    /// <summary>
    /// 12.6.8.支付机构查询汇款类业务项下子业务上传批次列表请求内容
    /// </summary>
    public class NTPAYQCLY
    {
        /// <summary>
        /// 业务种类	C(3)    ORT：汇出汇款——外汇清分提供 IRT：汇入汇款——企业银行提供
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 网上业务编号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 分行号	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 上传日期From	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 上传日期From	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 上传日期To	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 上传日期To	D, 对应<see cref="ENDDAT"/>
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
