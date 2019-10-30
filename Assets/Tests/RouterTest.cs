﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using LeanCloud.Play;
using System.Threading.Tasks;

namespace LeanCloud.Play.Test
{
    public class RouterTest
    {
        [SetUp]
        public void SetUp() {
            Logger.LogDelegate += Utils.Log;
        }

        [TearDown]
        public void TearDown() {
            Logger.LogDelegate -= Utils.Log;
        }

        [UnityTest]
        public IEnumerator PlayServer() {
            var f = false;
            var appId = "pyon3kvufmleg773ahop2i7zy0tz2rfjx5bh82n7h5jzuwjg";
            var appKey = "MJSm46Uu6LjF5eNmqfbuUmt6";
            var userId = "rt0";
            var playServer = "https://api2.ziting.wang";
            var c = new Client(appId, appKey, userId, playServer: playServer);
            c.Connect().OnSuccess(_ => { 
                return c.CreateRoom();
            }, TaskScheduler.FromCurrentSynchronizationContext()).Unwrap().OnSuccess(async _ => {
                await c.Close();
                f = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());

            while (!f) {
                yield return null;
            }
        }
    }
}
