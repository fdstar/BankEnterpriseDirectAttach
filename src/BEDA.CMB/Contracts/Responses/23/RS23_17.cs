using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 23.17.口头挂失响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_17 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRPHO
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRPHO";
        /// <summary>
        /// 23.17.口头挂失响应内容
        /// </summary>
        public NTCPRPHOZ NTCPRPHOZ { get; set; }
    }
    /// <summary>
    /// 23.17.口头挂失响应内容
    /// </summary>
    public class NTCPRPHOZ
    {
        /// <summary>
        /// 有效期     	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 有效期     	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
    }
}
