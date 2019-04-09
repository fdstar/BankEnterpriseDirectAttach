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
    /// 17.14.批量新增虚拟户请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_14 : CMBBase<RQINFO>, IRequest<RS17_14>
    {
        /// <summary>
        /// NTDMABAD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMABAD";
        /// <summary>
        /// 17.14.批量新增虚拟户请求内容
        /// </summary>
        public NTDMABADX1 NTDMABADX1 { get; set; }
        /// <summary>
        /// 17.14.批量新增虚拟户请求集合
        /// </summary>
        [XmlElement("NTDMABADX2")]
        public List<NTDMABADX2> List { get; set; }
    }
    /// <summary>
    /// 17.14.批量新增虚拟户请求内容
    /// </summary>
    public class NTDMABADX1
    {
        /// <summary>
        /// 操作类型	C(1)	D:直接开户； L:清单导入
        /// </summary>
        public string OPRCOD { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 起始虚拟户编号	C(20)   OPRCOD为D时，必填
        /// </summary>
        public string BEGDMA { get; set; }
        /// <summary>
        /// 结束虚拟户编号	C(20)   OPRCOD为D时，必填，且大于等于起始虚拟户编号
        /// </summary>
        public string ENDDMA { get; set; }
        /// <summary>
        /// 虚拟户户名前缀	Z(62)   OPRCOD为D时，必填
        /// </summary>
        public string DMAFIX { get; set; }
        /// <summary>
        /// 额度控制标志	C(1)	Y：允许透支N：不允许透支
        /// </summary>
        public string OVRCTL { get; set; }
        /// <summary>
        /// 退票处理方式	C(1)	Y:退回原虚拟户N：退回结算户
        /// </summary>
        public string BCKTYP { get; set; }
    }
    /// <summary>
    /// 17.7.虚拟户冲账请求内容
    /// </summary>
    public class NTDMABADX2
    {
        /// <summary>
        /// 虚拟户编号	C(20)   OPRCOD为L（清单导入）时必填
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)   OPRCOD为L（清单导入）时必填
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 额度控制标志	C(1)	Y：允许透支N：不允许透支
        /// </summary>
        public string OVRCTL { get; set; }
        /// <summary>
        /// 退票处理方式	C(1)	Y:退回原虚拟户N：退回结算户
        /// </summary>
        public string BCKTYP { get; set; }
    }
}
