
using System;

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using MvvmLightWpf.Services;

namespace MvvmLightWpf.ViewModel
{
    public class VMBase:ViewModelBase
    {
        //这是其它业务ViewModel可能会用到的服务类，全部在Locator中注册
        public ConfigService configService = ServiceLocator.Current.GetInstance<ConfigService>(); 

        public VMBase()
        {

        }

        public void ShowMsg(String msg)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                Messenger.Default.Send<String>(msg, "ShowMessage");
            });

        }
        public void SendMsg<T>(String token, T msg)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                Messenger.Default.Send<T>(msg, token);
            });

        }
    }
}
