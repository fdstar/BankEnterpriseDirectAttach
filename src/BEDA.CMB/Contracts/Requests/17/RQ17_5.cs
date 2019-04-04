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
    /// 17.5.记账宝交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_5 : CMBBase<RQINFO>, IRequest<RS17_5>
    {
        /// <summary>
        /// NTDTHQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDTHQRY";
        /// <summary>
        /// 17.5.记账宝交易查询请求内容
        /// </summary>
        public NTDTHQRYY NTDTHQRYY { get; set; }
    }
    /// <summary>
    /// 17.5.记账宝交易查询请求内容
    /// </summary>
    public class NTDTHQRYY
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 查询标志	C(1)	1：手工记账  2：虚拟户冲账
        /// </summary>
        public string QRYFLG { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)   查询标志为1时输入为空； 查询标志为2时输入虚拟户编号或为空（可以查询所有，不包括默认虚拟户）
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 起始日期	D   当月或上月的日期
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BEGDAT"/>
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
        /// 结束日期	D   小于或等于当天，大于或等于起始日期
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
