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
    /// 21.1.2.交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_1_2 : CMBBase<RQINFO>, IRequest<RS21_1_2>
    {
        /// <summary>
        /// NTQRYEBN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYEBN";
        /// <summary>
        /// 21.1.2.交易查询请求内容
        /// </summary>
        public NTQRYEBNY1 NTQRYEBNY1 { get; set; }
    }
    /// <summary>
    /// 21.1.2.交易查询请求内容
    /// </summary>
    public class NTQRYEBNY1
    {
        /// <summary>
        /// 业务类型	C(6)	N31010:跨行付款 N31011:跨行收款
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)    指定的单一模式 如00001
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
        /// 保留字50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
