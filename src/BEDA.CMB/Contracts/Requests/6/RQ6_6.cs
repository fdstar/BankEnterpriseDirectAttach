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
    /// 6.6.商务支付退款功能请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_6 : CMBBase<RQINFO>, IRequest<RS6_6>
    {
        /// <summary>
        /// NTB2BDBK
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTB2BDBK";
        /// <summary>
        /// 6.6.商务支付退款功能请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 6.6.商务支付退款功能请求内容
        /// </summary>
        public NTB2BDBKX1 NTB2BDBKX1 { get; set; }
    }
    /// <summary>
    /// 6.6.商务支付退款功能请求内容
    /// </summary>
    public class NTB2BDBKX1
    {
        /// <summary>
        /// 商户号        	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 对方订单号     	C(40)   原商户订单号
        /// </summary>
        public string REFORD { get; set; }
        /// <summary>
        /// 对方订单支付号	C(10)   原商户订单支付号
        /// </summary>
        public string SUBORD { get; set; }
        /// <summary>
        /// 银行订单号     	C(10)   取GetOrderStatus接口查询返回SEQNBR字段
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 银行订单支付号    	C(10)   取GetOrderStatus接口查询返回SUBSEQ字段
        /// </summary>
        public string SUBSEQ { get; set; }
        /// <summary>
        /// 对方商户号    	C(10)   与商户号一致
        /// </summary>
        public string REFMCH { get; set; }
        /// <summary>
        /// 业务参考号    	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 币种          	C(2)	10:人民币  必须与原订单交易币种一致，只支持人民币
        /// </summary>
        public string CCYNBR { get; set; } = "10";
        /// <summary>
        /// 退款金额      	M   必须与原订单交易金额一致
        /// </summary>
        public decimal RFNAMT { get; set; }
        /// <summary>
        /// 付款人银行账号	C(35)   必须与原订单付方账户一致
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 付款人户名	Z(200)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 付款人开户行	Z(62)   填写“招商银行” 只支持我行账号
        /// </summary>
        public string PAYBNK { get; set; } = "招商银行";
        /// <summary>
        /// 付款人商户平台用户名	Z(62)
        /// </summary>
        public string LGNNAM { get; set; }
        /// <summary>
        /// 付款人商户平台账号	C(20)
        /// </summary>
        public string LGNUSR { get; set; }
        /// <summary>
        /// 付款人商户平台手机号	C(20)
        /// </summary>
        public string LGNPHO { get; set; }
        /// <summary>
        /// 结算通道   	C(1)	F：快速 N：普通   不输则取原订单结算通道
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 用途       	Z(62)   不填默认返回“订单返款+原商户订单号”
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 业务种类   	C(6)    默认100001
        /// 100001=普通汇兑 
        /// 101001=慈善捐款             
        /// 101002 =其他
        /// </summary>
        public string TRSTYP { get; set; }
    }
}
