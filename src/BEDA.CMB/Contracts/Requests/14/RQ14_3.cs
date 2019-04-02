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
    /// 14.3.大额划拨经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ14_3 : CMBBase<RQINFO>, IRequest<RS14_3>
    {
        /// <summary>
        /// SDKNTOPRFMT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTOPRFMT";
        /// <summary>
        /// 14.3.大额划拨经办请求内容
        /// 注意此处只传递 BUSMOD 和 MODALS 业务模式、业务模式名称必须填一个
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 14.3.大额划拨经办请求内容
        /// </summary>
        public NTOPRFMTX NTOPRFMTX { get; set; }
    }
    /// <summary>
    /// 14.3.大额划拨经办请求内容
    /// </summary>
    public class NTOPRFMTX
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	C(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 划拨方向	C(3)	PTS:母公司划拨给子公司；STP:子公司划拨给母公司
        /// </summary>
        public string BRPDRT { get; set; }
        /// <summary>
        /// 划拨金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 币种	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 期望日	D   默认为当前日期
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime { get; set; }
        /// <summary>
        /// 期望日	D   默认为当天
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.ExpectedTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 期望时间	T   默认为‘000000’
        /// </summary>
        [XmlElement("EPTTIM")]
        public string EPTTIMStr
        {
            get
            {
                return this.ExpectedTime?.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
