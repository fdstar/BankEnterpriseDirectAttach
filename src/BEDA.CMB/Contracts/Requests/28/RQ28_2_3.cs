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
    /// 28.2.3.虚拟户交易利息试算请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_3 : CMBBase<RQINFO>, IRequest<RS28_2_3>
    {
        /// <summary>
        /// NTDMIQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMIQRY";
        /// <summary>
        /// 28.2.3.虚拟户交易利息试算请求内容
        /// </summary>
        public NTDMIQRYX1 NTDMIQRYX1 { get; set; }
    }
    /// <summary>
    /// 28.2.3.虚拟户交易利息试算请求内容
    /// </summary>
    public class NTDMIQRYX1
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DYANBR { get; set; }
        /// <summary>
        /// 利率类型	C(3)	FIX:对公活期利率 OTH:自定义利率
        /// </summary>
        public string INTTYP { get; set; }
        /// <summary>
        /// 利率	F(11,7) 利率类型为OTH时，必须为正； 其他类型必须为0
        /// </summary>
        public decimal INTVAL { get; set; }
        /// <summary>
        /// 结束日	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日	D, 对应<see cref="ENDDAT"/>
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
        /// 原交易流水号	C(15)
        /// </summary>
        public string ORGTRX { get; set; }
        /// <summary>
        /// 原交易套号	C(15)
        /// </summary>
        public string ORGSET { get; set; }
    }
}
