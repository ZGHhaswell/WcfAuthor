/*----------------------------------------------------------------
// Copyright (C) 2013 ZGH
// 版权所有。
//
// 文件名：RemoteCalculator.cs
// 功能描述：
// 
// 创建时间： 7/1/2015 9:57:59 PM
//
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using WcfContract;

namespace WcfServer.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    public class RemoteCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}