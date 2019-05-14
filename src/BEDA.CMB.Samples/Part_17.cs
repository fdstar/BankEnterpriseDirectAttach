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
        static void Part_17()
        {
            //RQ17_1Sample(); //test
            //RQ17_2Sample(); //test
            //RQ17_3Sample(); //test
            //RQ17_4Sample(); //test
            //RQ17_5Sample(); //test
            //RQ17_6Sample(); //test
            //RQ17_7Sample(); //test
        }

        #region 17.记账宝
        /// <summary>
        /// 17.1.查询记账宝帐号列表
        /// </summary>
        public static void RQ17_1Sample()
        {
            var rq = new RQ17_1()
            {
                NTDMACTLX = new NTDMACTLX
                {
                }
            };
            var rs = client.Execute<RQ17_1, RS17_1>(rq, "银企直连测试用户110");
            var txt = string.Join(",", rs.List.Select(x => x.ACCNBR)); //755915712310502,755915712310607,755915712310806
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.2.查询虚拟户信息
        /// </summary>
        public static void RQ17_2Sample()
        {
            var rq = new RQ17_2()
            {
                NTDMALSTX = new NTDMALSTX
                {
                    ACCNBR = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_2, RS17_2>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.3.新增虚拟户
        /// </summary>
        public static void RQ17_3Sample()
        {
            var rq = new RQ17_3()
            {
                NTDMAADDX = new NTDMAADDX
                {
                    ACCNBR = "755915712310806",
                    DMANBR = "9911334455",
                    DMANAM = "BEDA测试创建01",
                }
            };
            var rs = client.Execute<RQ17_3, RS17_3>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.4.关闭虚拟户
        /// </summary>
        public static void RQ17_4Sample()
        {
            var rq = new RQ17_4()
            {
                NTDMADLTX1 = new NTDMADLTX1
                {
                    ACCNBR = "755915712310806",
                },
                List = new List<NTDMADLTX2>
                {
                    new NTDMADLTX2
                    {
                        DMANBR="9911334455"
                    }
                }
            };
            var rs = client.Execute<RQ17_4, RS17_4>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.5.记账宝交易查询
        /// </summary>
        public static void RQ17_5Sample()
        {
            for (var i = 7; i < 9; i++)
            {
                var dt = DateTime.Now.AddMonths(-i);
                var rq = new RQ17_5()
                {
                    NTDTHQRYY = new NTDTHQRYY
                    {
                        ACCNBR = "755915712310806",
                        QRYFLG = "2",
                        BEGDAT = dt,
                        ENDDAT = dt.AddDays(1),
                    }
                };
                var rs = client.Execute<RQ17_5, RS17_5>(rq, "银企直连测试用户110");
                if (rs.INFO.RETCOD == "0")
                {//i为7和8时有返回值
                    Console.WriteLine(rs.INFO.ResponseContent);
                }
            }
        }
        /// <summary>
        /// 17.6.手工记账
        /// </summary>
        public static void RQ17_6Sample()
        {
            var rq = new RQ17_6()
            {
                NTHKPACTX1 = new NTHKPACTX1
                {
                    ACCNBR = "755915712310806",
                    DMANBR = "1804120002",
                },
                List = new List<NTHKPACTX2>
                {
                    new NTHKPACTX2
                    {
                        TRXDAT=new DateTime(2018,8,1),
                        TRXNBR="TX0000000000021",
                    }
                }
            };
            var rs = client.Execute<RQ17_6, RS17_6>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.7.虚拟户冲账
        /// </summary>
        public static void RQ17_7Sample()
        {
            var rq = new RQ17_7()
            {
                NTHCLACTX1 = new NTHCLACTX1
                {
                    ACCNBR = "755915712310806",
                },
                List = new List<NTHCLACTX2>
                {
                    new NTHCLACTX2
                    {
                        DMANBR = "1804120002",
                        TRXDAT=new DateTime(2018,8,1),
                        TRXNBR="TX0000001000001",
                    }
                }
            };
            var rs = client.Execute<RQ17_7, RS17_7>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
