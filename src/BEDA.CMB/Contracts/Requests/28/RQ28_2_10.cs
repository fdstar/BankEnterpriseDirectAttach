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
    /// 28.2.10.大额划拨经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_10 : CMBBase<RQINFO>, IRequest<RS28_2_10>
    {
        /// <summary>
        /// NTOPRGMD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRGMD";
        /// <summary>
        /// 28.2.10.大额划拨经办请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 28.2.10.大额划拨经办请求内容
        /// </summary>
        public NTOPRGMDX1 NTOPRGMDX1 { get; set; }
    }
    /// <summary>
    /// 28.2.10.大额划拨经办请求内容
    /// </summary>
    public class NTOPRGMDX1
    {
        /// <summary>
        /// 协议编号    	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	C(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 划拨方向    	C(3)	PTS:母公司划拨给子公司； STP:子公司划拨给母公司
        /// </summary>
        public string BRPDRT { get; set; }
        /// <summary>
        /// 划拨金额    	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 对方参考号  	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
