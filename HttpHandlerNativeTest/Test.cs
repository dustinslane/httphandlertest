using System;
using System.Net;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using Debug = CitizenFX.Core.Debug;

namespace HttpHandlerNativeTest
{
    /// <summary>
    /// Test case to make FXServer crash
    ///
    /// Using Mono 4.5.2
    /// Using CFXServer 1164
    /// </summary>
    public class Test : BaseScript
    {
        private static HttpListener HttpListener;
        public Test()
        {
            Debug.WriteLine("Test Loaded");
            API.SetHttpHandler(new Action<dynamic, dynamic>(HandleHttpRequest));

        }

        private async void HandleHttpRequest(dynamic request, dynamic response)
        {
            Debug.WriteLine("Ha");
        }
    }
}