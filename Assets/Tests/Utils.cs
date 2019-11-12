﻿using UnityEngine;
using LeanCloud.Common;

namespace LeanCloud.Play {
    internal static class Utils {
        internal static Client NewClient(string userId) {
            // 华东节点，开发版本
            var appId = "FQr8l8LLvdxIwhMHN77sNluX-9Nh9j0Va";
            var appKey = "MJSm46Uu6LjF5eNmqfbuUmt6";
            var playServer = "https://fqr8l8ll.lc-cn-e1-shared.com";
            return new Client(appId, appKey, userId, playServer: playServer);
        }

        internal static void Log(LogLevel level, string info) { 
            switch (level) {
                case LogLevel.Debug:
                    Debug.LogFormat("[DEBUG] {0}", info);
                    break;
                case LogLevel.Warn:
                    Debug.LogFormat("[WARNING] {0}", info);
                    break;
                case LogLevel.Error:
                    Debug.LogFormat("[ERROR] {0}", info);
                    break;
                default:
                    Debug.Log(info);
                    break;
            }
        }
    }
}