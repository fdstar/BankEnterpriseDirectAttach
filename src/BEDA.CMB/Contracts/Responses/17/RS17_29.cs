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
    /// 17.29.查询所有虚拟户的某日余额响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_29 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMAHBD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAHBD";
        /// <summary>
        /// 17.29.查询所有虚拟户的某日余额响应集合
        /// </summary>
        [XmlElement("NTDMAHBDZ1")]
        public List<NTDMAHBDZ1> List { get; set; }
        /// <summary>
        /// 17.29.查询所有虚拟户的某日余额响应内容
        /// </summary>
        public NTDMAHBDZ2 NTDMAHBDZ2 { get; set; }
    }
    /// <summary>
    /// 17.29.查询所有虚拟户的某日余额响应内容
    /// </summary>
    public class NTDMAHBDZ2
    {
        /// <summary>
        /// 续传标志	C(1)	Y：有续传，N：无续传
        /// </summary>
        public string CTNFLG { get; set; }
        /// <summary>
        /// 续传虚拟户	C(20)   有续传时非空，无续传空
        /// </summary>
        public string DMANBR { get; set; }
    }
    /// <summary>
    /// 17.29.查询所有虚拟户的某日余额响应内容
    /// </summary>
    public class NTDMAHBDZ1
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
