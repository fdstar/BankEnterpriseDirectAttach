using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 9.4.额度附加信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ9_4 : CMBBase<RQINFO>, IRequest<RS9_4>
    {
        /// <summary>
        /// NTNETDZI
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZI";
        /// <summary>
        /// 9.4.额度附加信息查询请求内容
        /// </summary>
        public NTNETDZIY1 NTNETDZIY1 { get; set; }
    }
    /// <summary>
    /// 9.4.额度附加信息查询请求内容
    /// </summary>
    public class NTNETDZIY1
    {
        /// <summary>
        /// 文件区分	C(10)	填“AMBRNDTAP”
        /// </summary>
        public string FLENAM { get; set; }
        /// <summary>
        /// 额度编号	C(10)
        /// </summary>
        public string RCDNUM { get; set; }
        /// <summary>
        /// 附加项目	C(6)	CRYNUM：混用币种 BUSTYP：适应业务
        /// </summary>
        public string ITMNUM { get; set; }
        /// <summary>
        /// 备用字段	C(24)
        /// </summary>
        public string RSVFLD { get; set; }
    }
}
