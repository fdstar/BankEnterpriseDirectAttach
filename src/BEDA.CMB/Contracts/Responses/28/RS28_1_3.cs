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
    /// 28.1.3.虚拟户查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_1_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDUMQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDUMQRY";
        /// <summary>
        /// 28.1.3.虚拟户查询响应集合
        /// </summary>
        [XmlElement("NTDUMQRYZ1")]
        public List<NTDUMQRYZ1> List { get; set; }
    }
    /// <summary>
    /// 28.1.3.虚拟户查询响应内容
    /// </summary>
    public class NTDUMQRYZ1
    {
        /// <summary>
        /// 虚拟户编号	C(20)	
        /// </summary>
        public string DYANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(200)
        /// </summary>
        public string DYANAM { get; set; }
        /// <summary>
        /// 虚拟户币种	C(2)	附录A.3
        /// </summary>
        public string DYACCY { get; set; }
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 状态	C(1)	附录A.5
        /// </summary>
        public string STSCOD { get; set; }
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
        /// 过账日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime PSTDAT { get; set; }
        /// <summary>
        /// 过账日期	D, 对应<see cref="PSTDAT"/>
        /// </summary>
        [XmlElement("PSTDAT")]
        public string PSTDATStr
        {
            get
            {
                return this.PSTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PSTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 上日余额	M
        /// </summary>
        public decimal PSTBAL { get; set; }
        /// <summary>
        /// 最新更新余额记账日	D
        /// </summary>
        [XmlIgnore]
        public DateTime UPTDAT { get; set; }
        /// <summary>
        /// 最新更新余额记账日	D, 对应<see cref="UPTDAT"/>
        /// </summary>
        [XmlElement("UPTDAT")]
        public string UPTDATStr
        {
            get
            {
                return this.UPTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.UPTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 实时更新余额	M
        /// </summary>
        public decimal UPTBAL { get; set; }
    }
}
