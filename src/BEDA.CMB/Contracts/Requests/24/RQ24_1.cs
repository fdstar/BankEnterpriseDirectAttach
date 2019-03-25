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
    /// 24.1.网银对账待经办数据查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ24_1 : CMBBase<RQINFO>, IRequest<RS24_1>
    {
        /// <summary>
        /// NTNSTQRY1
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNSTQRY1";
        /// <summary>
        /// 24.1.网银对账待经办数据查询请求内容 
        /// 此处不传递<see cref="NTNSTQRYX.REQNBR"/>
        /// </summary>
        public NTNSTQRYX NTNSTQRYX { get; set; }
    }
    /// <summary>
    /// 24.1.网银对账待经办数据查询请求内容
    /// </summary>
    public class NTNSTQRYX
    {
        /// <summary>
        /// 流程实例号     	C(10)   用于取经办过的数据户口序号和结果摘要
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 户口号         	C(35)   查全部户口时，传空，单个户口时精确查询
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 业务模式       	C(5)    查单个户口数据时，传空。查所有的户口时传全“*”或指定模式
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 对账月份       	C(6)   
        /// </summary>
        public string YERMTH { get; set; }
        /// <summary>
        /// 结束对账月份   	C(6)    不能早于对账月份
        /// </summary>
        public string ENDMTH { get; set; }
        /// <summary>
        /// 是否显示完成标志	C(1)    如果返回N  表示数据还没传输完，还有数据需要对账 这里实现不了续传，只能每次固定返回多少条记录，没查询一次都会将查询输入接口返回，通过这个字段提示用户是否还有数据需要对账
        /// </summary>
        public string CNTFLG { get; set; }
    }
}
