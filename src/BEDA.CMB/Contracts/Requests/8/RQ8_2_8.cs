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
    /// 8.2.8.智能现金池投资计划综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_2_8 : CMBBase<RQINFO>, IRequest<RS8_2_8>
    {
        /// <summary>
        /// NTQRYFIX    
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYFIX";
        /// <summary>
        /// 8.2.8.智能现金池投资计划综合查询请求内容
        /// </summary>
        public NTQRYFIXX NTQRYFIXX { get; set; }
    }
    /// <summary>
    /// 8.2.8.智能现金池投资计划综合查询请求内容
    /// </summary>
    public class NTQRYFIXX
    {
        /// <summary>
        /// 起始日期	D
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
        /// 终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 终止日期	D, 对应<see cref="ENDDAT"/>
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
        /// 帐号   	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 申请状态	C(3)	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 申请结果	C(1)	附录A.6
        /// </summary>
        public string RCDSTA { get; set; }
    }
}
