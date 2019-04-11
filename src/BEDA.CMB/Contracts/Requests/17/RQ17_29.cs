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
    /// 17.29.查询所有虚拟户的某日余额请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_29 : CMBBase<RQINFO>, IRequest<RS17_29>
    {
        /// <summary>
        /// NTDMAHBD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAHBD";
        /// <summary>
        /// 17.29.查询所有虚拟户的某日余额请求内容
        /// </summary>
        public NTDMAHBDX1 NTDMAHBDX1 { get; set; }
    }
    /// <summary>
    /// 17.29.查询所有虚拟户的某日余额请求内容
    /// </summary>
    public class NTDMAHBDX1
    {
        /// <summary>
        /// 分行号	C(2) 
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 查询日期	D   支持查询本年和去年的历史数据
        /// </summary>
        [XmlIgnore]
        public DateTime QRYDAT { get; set; }
        /// <summary>
        /// 查询日期	D, 对应<see cref="QRYDAT"/>
        /// </summary>
        [XmlElement("QRYDAT")]
        public string QRYDATStr
        {
            get
            {
                return this.QRYDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QRYDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 虚拟户	C(20)   首次查询空，续传查询传上次查询返回续传键值 （虚拟户、公司卡号、关联付方账号必须同时为空或同时有值）
        /// </summary>
        public string DMANBR { get; set; }
    }
}
