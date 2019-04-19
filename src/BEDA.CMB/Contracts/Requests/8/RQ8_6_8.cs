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
    /// 8.6.8.组合存款周期结息记录查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_6_8 : CMBBase<RQINFO>, IRequest<RS8_6_8>
    {
        /// <summary>
        /// NTCMAQDI
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAQDI";
        /// <summary>
        /// 8.6.8.组合存款周期结息记录查询请求内容
        /// </summary>
        public NTCMAQDIY1 NTCMAQDIY1 { get; set; }
    }
    /// <summary>
    /// 8.6.8.组合存款周期结息记录查询请求内容
    /// </summary>
    public class NTCMAQDIY1
    {
        /// <summary>
        /// 活期户口号 	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 协议编号	C(8)
        /// </summary>
        public string CSTNBR { get; set; }
        /// <summary>
        /// 查询起始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 查询起始日期	D, 对应<see cref="BEGDAT"/>
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
        /// 查询结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 查询结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// 保留字段   	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
