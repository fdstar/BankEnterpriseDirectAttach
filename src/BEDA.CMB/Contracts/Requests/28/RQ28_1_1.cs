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
    /// 28.1.1.新增虚拟户请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_1_1 : CMBBase<RQINFO>, IRequest<RS28_1_1>
    {
        /// <summary>
        /// NTDUMADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDUMADD";
        /// <summary>
        /// 28.1.1.新增虚拟户请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 28.1.1.新增虚拟户请求内容
        /// </summary>
        public NTDUMADDX1 NTDUMADDX1 { get; set; }
    }
    /// <summary>
    /// 28.1.1.新增虚拟户请求内容
    /// </summary>
    public class NTDUMADDX1
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
        /// 虚拟户户名	Z(200)
        /// </summary>
        public string DYANAM { get; set; }
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
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
