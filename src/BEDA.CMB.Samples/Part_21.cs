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
        static void Part_21()
        {
            //RQ21_1_1Sample();
            //RQ21_1_2Sample();
            //RQ21_1_3Sample();
            //RQ21_1_4Sample();
            //RQ21_1_5Sample();
            //RQ21_1_6Sample();
        }

        #region 21.网银互联
        /// <summary>
        /// 21.1.1.查询业务经办业务控制信息
        /// </summary>
        public static void RQ21_1_1Sample()
        {
            var rq = new RQ21_1_1()
            {
                NTBUSMODY = new NTBUSMODY
                {
                    BUSCOD = "N31010",
                    // N31010=网银贷记
                    // N31011=网银借记
                    // N31012 = 第三方贷记
                    // N31013=跨行账户信息查询
                }
            };
            var rs = client.Execute<RQ21_1_1, RS21_1_1>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.1.2.交易查询
        /// </summary>
        public static void RQ21_1_2Sample()
        {
            var rq = new RQ21_1_2()
            {
                NTQRYEBNY1 = new NTQRYEBNY1
                {
                    BUSCOD = "N31010",
                    BUSMOD = "00001",
                    BGNDAT = DateTime.Now.AddDays(-380),
                    ENDDAT = DateTime.Now.AddDays(-374)
                }
            };
            var rs = client.Execute<RQ21_1_2, RS21_1_2>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.1.3.业务交易明细查询
        /// </summary>
        public static void RQ21_1_3Sample()
        {
            var rq = new RQ21_1_3()
            {
                NTEBPINFX = new NTEBPINFX
                {
                    REQNBR = "0030091466"
                }
            };
            var rs = client.Execute<RQ21_1_3, RS21_1_3>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.1.4.取企业银行处理结果
        /// </summary>
        public static void RQ21_1_4Sample()
        {
            var rq = new RQ21_1_4()
            {
                NTRTVSTSX = new NTRTVSTSX
                {
                    REQNBR = "0030091466"
                }
            };
            var rs = client.Execute<RQ21_1_4, RS21_1_4>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.1.5.业务总揽查询
        /// </summary>
        public static void RQ21_1_5Sample()
        {
            var rq = new RQ21_1_5()
            {
                NTQNPEBPY = new NTQNPEBPY
                {
                    QRYACC = "755914749110111",
                    TRXDIR = "O",
                    MSGNBR = "101",
                    BGNDAT = DateTime.Now.AddDays(-380),
                    ENDDAT = DateTime.Now.AddDays(-360)
                }
            };
            var rs = client.Execute<RQ21_1_5, RS21_1_5>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.1.6.新交易查询-按业务参考号
        /// </summary>
        public static void RQ21_1_6Sample()
        {
            var rq = new RQ21_1_6()
            {
                NTQRYEBYX1 = new NTQRYEBYX1
                {
                    BUSCOD = "N31010",
                    YURREF = "APP83429820190219155056",
                    BGNDAT = DateTime.Now.AddDays(-380),
                    ENDDAT = DateTime.Now.AddDays(-374)
                }
            };
            var rs = client.Execute<RQ21_1_6, RS21_1_6>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
