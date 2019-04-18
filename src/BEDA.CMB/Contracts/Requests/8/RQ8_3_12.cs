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
    /// 8.3.12.步步为赢收益率历史查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_3_12 : CMBBase<RQINFO>, IRequest<RS8_3_12>
    {
        /// <summary>
        /// NTQDIPRH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDIPRH";
        /// <summary>
        /// 8.3.12.步步为赢收益率历史查询请求内容
        /// </summary>
        public NTQDIPRHX NTQDIPRHX { get; set; }
    }
    /// <summary>
    /// 8.3.12.步步为赢收益率历史查询请求内容
    /// </summary>
    public class NTQDIPRHX
    {
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string RIPCOD { get; set; }
        /// <summary>
        /// 收益率开始日期	D   查询日期范围不能大于100天
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 收益率开始日期	D, 对应<see cref="BEGDAT"/>
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
        /// 收益率结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 收益率结束日期	D, 对应<see cref="ENDDAT"/>
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
