/*----------------------------------------------------------------
// Copyright (C) 2013 ZGH
// 版权所有。
//
// 文件名：WcfHostFactory.cs
// 功能描述：
// 
// 创建时间： 7/1/2015 10:26:29 PM
//
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;

namespace WcfServer.Factories
{
    public class WcfHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new ServiceHost(serviceType, baseAddresses);
        }
    }
}