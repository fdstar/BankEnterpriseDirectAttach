using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CMB.Samples
{
    partial class Program
    {
        static void Part_06()
        {
            //RQ6_1Sample();
            //RQ6_10Sample();
        }

        #region 6.商务支付
        /// <summary>
        /// 6.1.查询订单状态信息
        /// </summary>
        public static void RQ6_1Sample()
        {
            var rq = new RQ6_1()
            {
                SDKTRDQYX = new SDKTRDQYX
                {
                    BEGSEQ = "ZF200700048-00003",
                }
            };
            var rs = client.Execute<RQ6_1, RS6_1>(rq, "银企直连专用普通1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }

        /// <summary>
        /// 6.10.订单列表查询
        /// </summary>
        public static void RQ6_10Sample()
        {
            var rq = new RQ6_10()
            {
                NTQRYORDY1 = new NTQRYORDY1
                {
                    BUSMOD = "00001",
                    BGNDAT = DateTime.Now.AddMonths(-8),
                    ENDDAT = DateTime.Now.AddMonths(-8).AddDays(6)
                }
            };
            var rs = client.Execute<RQ6_10, RS6_10>(rq, "银企直连专用普通1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
