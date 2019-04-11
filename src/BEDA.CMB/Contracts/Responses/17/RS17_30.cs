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
    /// 17.30.查询单个虚拟户的历史余额响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_30 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMAHAD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAHAD";
        /// <summary>
        /// 17.30.查询单个虚拟户的历史余额响应集合
        /// </summary>
        [XmlElement("NTDMAHADZ1")]
        public List<NTDMAHADZ1> List { get; set; }
    }
    /// <summary>
    /// 17.30.查询单个虚拟户的历史余额响应内容
    /// </summary>
    public class NTDMAHADZ1
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户	C(20) 
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82) 
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 币种	C(2) 
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime PSEDAT { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="PSEDAT"/>
        /// </summary>
        [XmlElement("PSEDAT")]
        public string PSEDATStr
        {
            get
            {
                return this.PSEDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PSEDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 余额	C(15)
        /// </summary>
        public decimal DMABAL { get; set; }
    }
}
