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
    /// 21.1.6.新交易查询-按业务参考号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_1_6 : CMBBase<RQINFO>, IRequest<RS21_1_6>
    {
        /// <summary>
        /// NTQRYEBY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYEBY";
        /// <summary>
        /// 21.1.6.新交易查询-按业务参考号请求内容
        /// </summary>
        public NTQRYEBYX1 NTQRYEBYX1 { get; set; }
    }
    /// <summary>
    /// 21.1.6.新交易查询-按业务参考号请求内容
    /// </summary>
    public class NTQRYEBYX1
    {
        /// <summary>
        /// 业务类型	C(6)	N31010:跨行付款 N31011:跨行收款
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 交易方向	C(1)	I：提回 O：提出
        /// </summary>
        public string TRXDIR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// 只查询指定的单笔（不提供模糊查询）
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 交易起始日期	D   按经办日期查询，起始结束日期间隔不能超过一周 起始日期不可小于当前日期前90天 （日切零点附近的交易若查询不到可尝试跨日查询）
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 交易起始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 交易结束日期	D   按经办日期查询，起始结束日期间隔不能超过一周 起始日期不可小于当前日期前90天 （日切零点附近的交易若查询不到可尝试跨日查询）
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 交易结束日期	D, 对应<see cref="ENDDAT"/>
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
