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
    /// 17.10.查询虚拟户余额和当月积数响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMABAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMABAL";
        /// <summary>
        /// 17.10.查询虚拟户余额和当月积数响应集合
        /// </summary>
        [XmlElement("NTDMABALZ")]
        public List<NTDMABALZ> List { get; set; }
    }
    /// <summary>
    /// 17.10.查询虚拟户余额和当月积数响应内容
    /// </summary>
    public class NTDMABALZ
    {
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 虚拟户币种	C(2)
        /// </summary>
        public string DMACCY { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 新增用户名	Z(30)
        /// </summary>
        public string ADDUSR { get; set; }
        /// <summary>
        /// 余额	M
        /// </summary>
        public decimal ACTBAL { get; set; }
        /// <summary>
        /// 当月积数	F(17,2) 默认虚拟户的积数为0
        /// </summary>
        public decimal MTHAUB { get; set; }
        /// <summary>
        /// 状态	C(1)    都是A
        /// </summary>
        public string STSCOD { get; set; }
    }
}
