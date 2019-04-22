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
    /// 12.2.3.支付机构上传实时购结汇项下购汇明细数据请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_2_3 : CMBBase<RQINFO>, IRequest<RS12_2_3>
    {
        /// <summary>
        /// NTPAYVEN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYVEN";
        /// <summary>
        /// 12.2.3.支付机构上传实时购结汇项下购汇明细数据请求内容
        /// </summary>
        public NTEXCBCHX NTEXCBCHX { get; set; }
        /// <summary>
        /// 12.2.3.支付机构上传实时购结汇项下购汇明细数据请求集合
        /// </summary>
        [XmlElement("NTVENDTLX")]
        public List<NTVENDTLX> List { get; set; }
    }
    /// <summary>
    /// 12.2.3.支付机构上传实时购结汇项下购汇明细数据请求内容
    /// </summary>
    public class NTEXCBCHX
    {
        /// <summary>
        /// 母业务网上业务编号	C（30）   输入值要与母业务的输入接口NTJSHOPRX. APPCNO相同
        /// </summary>
        public string APPCNO { get; set; }
        /// <summary>
        /// 分行号	C(2)	A.1 招行分行    与母业务相同
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号	C(10)   与母业务相同
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 业务模式	C(5)    业务N07111的业务模式
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 母业务流程实例号	C(10)   可通过母业务返回报文获得
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务种类	C(3)	BEX：结汇申请 VEN：购汇申请
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 本批次轧差类型	C(1)	0、非轧差数据 3、余额在支出方的轧差 4、余额在收入方的轧差
        /// 余额在支出方的轧差：子业务明细数据有结汇数据也有售汇数据，但是结汇的总金额 > 售汇的总金额；
        /// 余额在购汇方的扎差：子业务明细数据有结汇数据也有售汇数据，但是购汇的总金额 > 结汇的总金额
        /// </summary>
        public string CALTYP { get; set; }
        /// <summary>
        /// 批次总笔数	N(6)    客户填入 如果上传的笔数等于总笔数，则当作收齐 后面不再收
        /// </summary>
        public int ALLCNT { get; set; }
        /// <summary>
        /// 本轮次明细类型	C(3)	BEX：结汇
        /// </summary>
        public string LODTYP { get; set; }
        /// <summary>
        /// 本轮次笔数	N(6)    用于核对本次上传的明细包是否完整，每轮最多100笔
        /// </summary>
        public int LODCNT { get; set; }
        /// <summary>
        /// 上传轮次序号	N(6)    需要指定且按顺序上传
        /// 注意：如果有结汇数据和售汇数据的，结汇数据和售汇数据的轮次序号是一起计算的，不是分别计算的（即同一笔母结汇业务的子业务上传的轮次序号统一计算）
        /// </summary>
        public int LODSEQ { get; set; }
        /// <summary>
        /// 保留字	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
